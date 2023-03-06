using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;
        Transactions transaction;
        int difficulty = 3;
        public BlockchainApp()
        {
            InitializeComponent();
            blockchain= new Blockchain();
            richTextBox1.Text = "New genesis block initialised!";
            

        }

        private void UpdateText(String text)
        {
            richTextBox1.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printBlock_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(blockID.Text, out int index))
                UpdateText(blockchain.GetBlockAsString(index));
            else
                UpdateText("\nInvalid Block No.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateWallet_Click(object sender, EventArgs e)
        {
            Wallet.Wallet newWallet = new Wallet.Wallet(out String privateKey);

            publicKeyText.Text = newWallet.publicID;
            privateKeyText.Text = privateKey;
        }

        private void validateKeys_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKeyText.Text, publicKeyText.Text))
                validationText.Text = "Keys are valid";
            else
                validationText.Text = "Keys are invalid";

        }

        private void transacButt_Click(object sender, EventArgs e)
        {
            transaction = new Transactions(publicKeyText.Text, privateKeyText.Text, recKeyTxt.Text, Convert.ToDouble(amountTxt.Text), Convert.ToDouble(feeTxt.Text));
            if (transaction.fee < blockchain.getBalance(publicKeyText.Text)) //Balance check before adding transaction
            {
                UpdateText("Less than required funds in wallet");
                return;
            }
            if (!Wallet.Wallet.ValidateSignature(publicKeyText.Text, transaction.hash, transaction.signature)) //Validate keys before adding transaction
            {
                UpdateText("Keys do not match");
                return;
            }
            UpdateText("\n");
            UpdateText(transaction.ToString());
            blockchain.transactionPool.Add(transaction);
            
            
        }

        private void transPool_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Join("\n", blockchain.transactionPool);
        }

        private void genNewBlock_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Block.difficulty = difficulty;

            List<Transactions> transactions = blockchain.GetPooledTransactions();
            Block newBlock = new Block(blockchain.GetLastBlockAsString(), transactions, publicKeyText.Text);
            blockchain.blocks.Add(newBlock);
            
            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            // Difficulty will be adjusted every 10 blocks
            if ((blockchain.blocks.Count - 1) % 10 == 0)
            {
                // If blockmine time is significantly shorter than our desired range of a block time, increase difficulty
                if (ts.Seconds <= 40)
                {
                    difficulty++;
                }
                //Decrease difficulty once block time becomes too long
                else if (ts.Seconds >= 70)
                {
                    difficulty--;
                }
            }


            
            
            UpdateText(newBlock.ToString());
        }

        private void ValidChain_Click(object sender, EventArgs e)
        {

            if (blockchain.blocks.Count == 1) 
            {
                // Checking Genesis Block
                if (!Blockchain.ValidateHash(blockchain.blocks[0]))
                    richTextBox1.Text = "Blockchain is invalid";
                else
                    richTextBox1.Text = "Blockchain is valid";
                return;
            }
            for (int i = 1; i < blockchain.blocks.Count; i++)
            {
                // Compares hashes of current and last hash to see if they match and check transactions by validating the merkle root
                if (blockchain.blocks[i].prevhash != blockchain.blocks[i - 1].hash || !Blockchain.ValidateHash(blockchain.blocks[i])
                    || !Blockchain.ValidateMerkleRoot(blockchain.blocks[i]))
                {
                    UpdateText("Blockchain is invalid");
                    return;
                }
            }
            UpdateText("Blockchain is valid");
        }

        private void getBalance_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.getBalance(publicKeyText.Text).ToString() + " Doge Coin");
        }

        private void readAll_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Join("\n", blockchain.blocks);

        }
    }   
}
