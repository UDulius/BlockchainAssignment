using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public List<Block> blocks;
        public List<Transactions> transactionPool = new List<Transactions>();

        private int transacPerBlock = 5;

        public Blockchain()
        {
            blocks = new List<Block>()
            {
                new Block() //Generating genesis block
            };

            
        }
   
        //Returns all blocks generated in string format
        public String GetBlockAsString(int index)
        {
            return blocks[index].ToString();
        }

        //Returns the last block generated in string format
        public Block GetLastBlockAsString()
        {
            return blocks[blocks.Count - 1];
        }

        //Returns all transactions in string format
        public String GetTransactionAsString()
        {
            return transactionPool.ToString();
        }

        public List<Transactions> GetPooledTransactions()
        {
            //Finds the smallest value: Either the limit of transactions defined above or how many transactions appear in the pool
            int n = Math.Min(transacPerBlock, transactionPool.Count);
            //Finds given range and store them in a new list
            List<Transactions> transactions = transactionPool.GetRange(0, n);
            //Remove the transactions from pool
            transactionPool.RemoveRange(0, n);

            return transactions;
        }

        //Fetches balance of public key by going through each transaction in every block and transaction pool
        public double getBalance(String add)
        {
            double balance = 0;
            foreach(Block block in blocks)
            {
                foreach(Transactions transaction in block.transactionPool)
                {
                    if (transaction.recipientAddress.Equals(add))
                    {
                        balance += transaction.amount;
                    }
                    if (transaction.senderAddress.Equals(add))
                    {
                        balance -= (transaction.amount + transaction.fee);
                    }
                   
                }
            }
            return balance;
        }

        public static bool ValidateHash(Block block)
        {
            string rehash = block.createHash();
            return rehash.Equals(block.hash);
        }

        public static bool ValidateMerkleRoot(Block block) 
        {
            String reMerk = Block.MerkleRoot(block.transactionPool);
            return reMerk.Equals(block.merkleRoot);
        }

        public override string ToString()
        {
            return String.Join("\n\n", blocks);
        }
    }
}
