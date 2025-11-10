namespace Api_Split
{
    partial class Form1
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
            this.TxtSentence = new System.Windows.Forms.TextBox();
            this.TxtCharacter = new System.Windows.Forms.TextBox();
            this.BtnListOfWord = new System.Windows.Forms.Button();
            this.BtnNumberOfLetter = new System.Windows.Forms.Button();
            this.BtnNumberOfWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbiListOfWords = new System.Windows.Forms.Label();
            this.LbiNumberOfLetters = new System.Windows.Forms.Label();
            this.LbiNumberOfWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSentence
            // 
            this.TxtSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSentence.Location = new System.Drawing.Point(178, 131);
            this.TxtSentence.Name = "TxtSentence";
            this.TxtSentence.Size = new System.Drawing.Size(315, 38);
            this.TxtSentence.TabIndex = 0;
            // 
            // TxtCharacter
            // 
            this.TxtCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCharacter.Location = new System.Drawing.Point(178, 236);
            this.TxtCharacter.Name = "TxtCharacter";
            this.TxtCharacter.Size = new System.Drawing.Size(315, 38);
            this.TxtCharacter.TabIndex = 1;
            // 
            // BtnListOfWord
            // 
            this.BtnListOfWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListOfWord.Location = new System.Drawing.Point(178, 299);
            this.BtnListOfWord.Name = "BtnListOfWord";
            this.BtnListOfWord.Size = new System.Drawing.Size(101, 40);
            this.BtnListOfWord.TabIndex = 2;
            this.BtnListOfWord.Text = "لیست کلمات";
            this.BtnListOfWord.UseVisualStyleBackColor = true;
            this.BtnListOfWord.Click += new System.EventHandler(this.BtnListOfWord_Click);
            // 
            // BtnNumberOfLetter
            // 
            this.BtnNumberOfLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNumberOfLetter.Location = new System.Drawing.Point(285, 299);
            this.BtnNumberOfLetter.Name = "BtnNumberOfLetter";
            this.BtnNumberOfLetter.Size = new System.Drawing.Size(101, 40);
            this.BtnNumberOfLetter.TabIndex = 3;
            this.BtnNumberOfLetter.Text = "تعداد حروف";
            this.BtnNumberOfLetter.UseVisualStyleBackColor = true;
            this.BtnNumberOfLetter.Click += new System.EventHandler(this.BtnNumberOfLetter_Click);
            // 
            // BtnNumberOfWord
            // 
            this.BtnNumberOfWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNumberOfWord.Location = new System.Drawing.Point(392, 299);
            this.BtnNumberOfWord.Name = "BtnNumberOfWord";
            this.BtnNumberOfWord.Size = new System.Drawing.Size(101, 40);
            this.BtnNumberOfWord.TabIndex = 4;
            this.BtnNumberOfWord.Text = "تعداد کلمه";
            this.BtnNumberOfWord.UseVisualStyleBackColor = true;
            this.BtnNumberOfWord.Click += new System.EventHandler(this.BtnNumberOfWord_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "جمله مورد نظر را وارد کنید  ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "حرف مورد نظر را وارد کنید";
            // 
            // LbiListOfWords
            // 
            this.LbiListOfWords.AutoSize = true;
            this.LbiListOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbiListOfWords.Location = new System.Drawing.Point(164, 368);
            this.LbiListOfWords.Name = "LbiListOfWords";
            this.LbiListOfWords.Size = new System.Drawing.Size(0, 25);
            this.LbiListOfWords.TabIndex = 7;
            // 
            // LbiNumberOfLetters
            // 
            this.LbiNumberOfLetters.AutoSize = true;
            this.LbiNumberOfLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbiNumberOfLetters.Location = new System.Drawing.Point(322, 368);
            this.LbiNumberOfLetters.Name = "LbiNumberOfLetters";
            this.LbiNumberOfLetters.Size = new System.Drawing.Size(0, 25);
            this.LbiNumberOfLetters.TabIndex = 8;
            // 
            // LbiNumberOfWords
            // 
            this.LbiNumberOfWords.AutoSize = true;
            this.LbiNumberOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbiNumberOfWords.Location = new System.Drawing.Point(435, 368);
            this.LbiNumberOfWords.Name = "LbiNumberOfWords";
            this.LbiNumberOfWords.Size = new System.Drawing.Size(0, 25);
            this.LbiNumberOfWords.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 526);
            this.Controls.Add(this.LbiNumberOfWords);
            this.Controls.Add(this.LbiNumberOfLetters);
            this.Controls.Add(this.LbiListOfWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNumberOfWord);
            this.Controls.Add(this.BtnNumberOfLetter);
            this.Controls.Add(this.BtnListOfWord);
            this.Controls.Add(this.TxtCharacter);
            this.Controls.Add(this.TxtSentence);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSentence;
        private System.Windows.Forms.TextBox TxtCharacter;
        private System.Windows.Forms.Button BtnListOfWord;
        private System.Windows.Forms.Button BtnNumberOfLetter;
        private System.Windows.Forms.Button BtnNumberOfWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbiListOfWords;
        private System.Windows.Forms.Label LbiNumberOfLetters;
        private System.Windows.Forms.Label LbiNumberOfWords;
    }
}

