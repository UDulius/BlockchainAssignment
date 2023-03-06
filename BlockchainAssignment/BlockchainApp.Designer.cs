namespace BlockchainAssignment
{
    partial class BlockchainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printBlock = new System.Windows.Forms.Button();
            this.blockID = new System.Windows.Forms.TextBox();
            this.generateWallet = new System.Windows.Forms.Button();
            this.publicKeyText = new System.Windows.Forms.TextBox();
            this.privateKeyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.validateKeys = new System.Windows.Forms.Button();
            this.validationText = new System.Windows.Forms.TextBox();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.feeTxt = new System.Windows.Forms.TextBox();
            this.recKeyTxt = new System.Windows.Forms.TextBox();
            this.transacButt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.transPool = new System.Windows.Forms.Button();
            this.genNewBlock = new System.Windows.Forms.Button();
            this.ValidChain = new System.Windows.Forms.Button();
            this.getBalance = new System.Windows.Forms.Button();
            this.readAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(801, 317);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // printBlock
            // 
            this.printBlock.Location = new System.Drawing.Point(13, 333);
            this.printBlock.Name = "printBlock";
            this.printBlock.Size = new System.Drawing.Size(81, 23);
            this.printBlock.TabIndex = 1;
            this.printBlock.Text = "Print Block";
            this.printBlock.UseVisualStyleBackColor = true;
            this.printBlock.Click += new System.EventHandler(this.printBlock_Click);
            // 
            // blockID
            // 
            this.blockID.Location = new System.Drawing.Point(100, 335);
            this.blockID.Name = "blockID";
            this.blockID.Size = new System.Drawing.Size(35, 20);
            this.blockID.TabIndex = 2;
            this.blockID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // generateWallet
            // 
            this.generateWallet.Location = new System.Drawing.Point(738, 335);
            this.generateWallet.Name = "generateWallet";
            this.generateWallet.Size = new System.Drawing.Size(75, 56);
            this.generateWallet.TabIndex = 3;
            this.generateWallet.Text = "Generate Wallet";
            this.generateWallet.UseVisualStyleBackColor = true;
            this.generateWallet.Click += new System.EventHandler(this.generateWallet_Click);
            // 
            // publicKeyText
            // 
            this.publicKeyText.Location = new System.Drawing.Point(342, 341);
            this.publicKeyText.Name = "publicKeyText";
            this.publicKeyText.Size = new System.Drawing.Size(390, 20);
            this.publicKeyText.TabIndex = 4;
            // 
            // privateKeyText
            // 
            this.privateKeyText.Location = new System.Drawing.Point(342, 367);
            this.privateKeyText.Name = "privateKeyText";
            this.privateKeyText.Size = new System.Drawing.Size(390, 20);
            this.privateKeyText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Private Key";
            // 
            // validateKeys
            // 
            this.validateKeys.Location = new System.Drawing.Point(595, 397);
            this.validateKeys.Name = "validateKeys";
            this.validateKeys.Size = new System.Drawing.Size(106, 23);
            this.validateKeys.TabIndex = 8;
            this.validateKeys.Text = "Validate Keys";
            this.validateKeys.UseVisualStyleBackColor = true;
            this.validateKeys.Click += new System.EventHandler(this.validateKeys_Click);
            // 
            // validationText
            // 
            this.validationText.Location = new System.Drawing.Point(707, 399);
            this.validationText.Name = "validationText";
            this.validationText.Size = new System.Drawing.Size(106, 20);
            this.validationText.TabIndex = 9;
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(141, 463);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(55, 20);
            this.amountTxt.TabIndex = 10;
            // 
            // feeTxt
            // 
            this.feeTxt.Location = new System.Drawing.Point(141, 485);
            this.feeTxt.Name = "feeTxt";
            this.feeTxt.Size = new System.Drawing.Size(55, 20);
            this.feeTxt.TabIndex = 11;
            // 
            // recKeyTxt
            // 
            this.recKeyTxt.Location = new System.Drawing.Point(342, 489);
            this.recKeyTxt.Name = "recKeyTxt";
            this.recKeyTxt.Size = new System.Drawing.Size(390, 20);
            this.recKeyTxt.TabIndex = 12;
            // 
            // transacButt
            // 
            this.transacButt.Location = new System.Drawing.Point(12, 463);
            this.transacButt.Name = "transacButt";
            this.transacButt.Size = new System.Drawing.Size(82, 46);
            this.transacButt.TabIndex = 13;
            this.transacButt.Text = "Create Transaction";
            this.transacButt.UseVisualStyleBackColor = true;
            this.transacButt.Click += new System.EventHandler(this.transacButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Receiver Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fee";
            // 
            // transPool
            // 
            this.transPool.Location = new System.Drawing.Point(13, 434);
            this.transPool.Name = "transPool";
            this.transPool.Size = new System.Drawing.Size(81, 23);
            this.transPool.TabIndex = 17;
            this.transPool.Text = "Print Pool";
            this.transPool.UseVisualStyleBackColor = true;
            this.transPool.Click += new System.EventHandler(this.transPool_Click);
            // 
            // genNewBlock
            // 
            this.genNewBlock.Location = new System.Drawing.Point(13, 367);
            this.genNewBlock.Name = "genNewBlock";
            this.genNewBlock.Size = new System.Drawing.Size(81, 44);
            this.genNewBlock.TabIndex = 18;
            this.genNewBlock.Text = "Generate New Block";
            this.genNewBlock.UseVisualStyleBackColor = true;
            this.genNewBlock.Click += new System.EventHandler(this.genNewBlock_Click);
            // 
            // ValidChain
            // 
            this.ValidChain.Location = new System.Drawing.Point(595, 426);
            this.ValidChain.Name = "ValidChain";
            this.ValidChain.Size = new System.Drawing.Size(106, 23);
            this.ValidChain.TabIndex = 19;
            this.ValidChain.Text = "Validate Chain";
            this.ValidChain.UseVisualStyleBackColor = true;
            this.ValidChain.Click += new System.EventHandler(this.ValidChain_Click);
            // 
            // getBalance
            // 
            this.getBalance.Location = new System.Drawing.Point(707, 425);
            this.getBalance.Name = "getBalance";
            this.getBalance.Size = new System.Drawing.Size(106, 23);
            this.getBalance.TabIndex = 20;
            this.getBalance.Text = "Get Balance";
            this.getBalance.UseVisualStyleBackColor = true;
            this.getBalance.Click += new System.EventHandler(this.getBalance_Click);
            // 
            // readAll
            // 
            this.readAll.Location = new System.Drawing.Point(141, 334);
            this.readAll.Name = "readAll";
            this.readAll.Size = new System.Drawing.Size(75, 23);
            this.readAll.TabIndex = 21;
            this.readAll.Text = "Read All";
            this.readAll.UseVisualStyleBackColor = true;
            this.readAll.Click += new System.EventHandler(this.readAll_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 521);
            this.Controls.Add(this.readAll);
            this.Controls.Add(this.getBalance);
            this.Controls.Add(this.ValidChain);
            this.Controls.Add(this.genNewBlock);
            this.Controls.Add(this.transPool);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transacButt);
            this.Controls.Add(this.recKeyTxt);
            this.Controls.Add(this.feeTxt);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.validationText);
            this.Controls.Add(this.validateKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateKeyText);
            this.Controls.Add(this.publicKeyText);
            this.Controls.Add(this.generateWallet);
            this.Controls.Add(this.blockID);
            this.Controls.Add(this.printBlock);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button printBlock;
        private System.Windows.Forms.TextBox blockID;
        private System.Windows.Forms.Button generateWallet;
        private System.Windows.Forms.TextBox publicKeyText;
        private System.Windows.Forms.TextBox privateKeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validateKeys;
        private System.Windows.Forms.TextBox validationText;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox feeTxt;
        private System.Windows.Forms.TextBox recKeyTxt;
        private System.Windows.Forms.Button transacButt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button transPool;
        private System.Windows.Forms.Button genNewBlock;
        private System.Windows.Forms.Button ValidChain;
        private System.Windows.Forms.Button getBalance;
        private System.Windows.Forms.Button readAll;
    }
}

