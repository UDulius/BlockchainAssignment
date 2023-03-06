using System;
using System.Security.Cryptography;
using System.Text;

namespace BlockchainAssignment
{
    class Transactions
    {
        public String hash, signature, senderAddress, recipientAddress;
        public DateTime timestamp;
        public double amount, fee;

        public Transactions(String senderAdd, String senderPrivAdd, String recipientAdd, double amount, double fee)
        {
            senderAddress = senderAdd;
            recipientAddress = recipientAdd;
            this.fee = fee;
            this.amount = amount;
            timestamp = DateTime.Now;
            hash = createHash();
            signature = Wallet.Wallet.CreateSignature(senderAddress, senderPrivAdd, hash); 
        }

        public String createHash()
        {
            SHA256 hasher = SHA256Managed.Create();

            String input = senderAddress + recipientAddress + fee + amount + timestamp;
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            String hash = string.Empty;

            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);

            return hash;
        }

        public override string ToString()
        {
            return "\nTimestamp: " + timestamp
                + "\nTransaction Hash: " + hash
                + "\nSignature: " + signature
                + "\nTransferred: " + amount + " Doge Coin"
                + "\nFee : " + fee
                + "\nSender Address: " + senderAddress
                + "\nRecipient Address: " + recipientAddress;
        }
        
    }

   

}
