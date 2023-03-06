using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.CodeDom;

namespace BlockchainAssignment
{
    class Block { 

        private DateTime timestamp;

        public int index;
        public int nonce = 0;
        public static int difficulty;

        public double reward;
        public String hash;
        public String prevhash;
        public String minerAddress;
        public String merkleRoot;

        public List<Transactions> transactionPool = new List<Transactions>();

        public Block(Block lastBlock, List<Transactions> transaction, String minerAddress)
        {
            timestamp = DateTime.Now;

            index = lastBlock.index + 1;
            prevhash = lastBlock.hash;

            this.minerAddress = minerAddress;
            reward = 5.0;

            //Create new list of transactions that are being passed through from pool
            transaction.Add(GetRewardFees(transaction));
            transactionPool = new List<Transactions>(transaction);
            merkleRoot = MerkleRoot(transactionPool);
            hash = Mine();
        }

        public Block()
        {
            timestamp= DateTime.Now;
            index = 0;
            transactionPool = new List<Transactions>();
            merkleRoot = String.Empty;
            hash = Mine();
            
        }

        public String createHash()
        {
            SHA256 hasher = SHA256Managed.Create();

            String input = index.ToString() + timestamp.ToString() + prevhash + nonce + difficulty + reward + merkleRoot;
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            String hash = string.Empty;

            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);

            return hash;
        }

        public String Mine()
        {
            String hash = createHash();

            String start = new string('0', difficulty);

            while (!hash.StartsWith(start))
            {
                nonce++;
                hash = createHash();
            }
            return hash;
        }
     
        public Transactions GetRewardFees(List<Transactions> transaction)
        {
            double fees = transaction.Aggregate(0.0, (acc, t) => acc + t.fee);
            return new Transactions("Mine Rewards", "", minerAddress, (reward + fees), 0);
        }

        public static String MerkleRoot(List<Transactions> transactionPool)
        {
            List<String> pairedHash = transactionPool.Select(transaction => transaction.hash).ToList();
            if(pairedHash.Count == 0)
            {
                return String.Empty;
            }
            if(pairedHash.Count == 1)
            {
                return HashCode.HashTools.CombineHash(pairedHash[0], pairedHash[0]);
            }
            while(pairedHash.Count != 1)
            {
                List<String> merkleLeaves = new List<String>();
                for(int i = 0; i<pairedHash.Count; i += 2)
                {
                    if(i == pairedHash.Count - 1)
                    {
                        merkleLeaves.Add(HashCode.HashTools.CombineHash(pairedHash[i], pairedHash[i]));
                    }
                    else
                    {
                        merkleLeaves.Add(HashCode.HashTools.CombineHash(pairedHash[i], pairedHash[i + 1]));
                    }
                }
                pairedHash = merkleLeaves;
            }
            return pairedHash[0];
        }


        
        
        public override string ToString()
        {
            return "BLOCK START ----"
                + "\nTimestamp: " + timestamp
                + "\nBlock Index: " + index
                + "\nHash: " + hash
                + "\nPrevious Hash: " + prevhash
                + "\nNonce: " + nonce
                + "\nDifficulty Level: " + difficulty
                + "\nReward: " + reward
                + "\nMiner Address: " + minerAddress
                + "\nTransactions: " + transactionPool.Count() + "\n" + String.Join("\n", transactionPool);
        }

        
    }
}
