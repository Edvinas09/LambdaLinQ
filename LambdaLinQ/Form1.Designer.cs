
namespace LambdaLinQ
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
            this.lstData = new System.Windows.Forms.ListBox();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnLinQ = new System.Windows.Forms.Button();
            this.btnFindVardenis = new System.Windows.Forms.Button();
            this.btnFindLinQ = new System.Windows.Forms.Button();
            this.btnSortList = new System.Windows.Forms.Button();
            this.btnShowOnlyProp = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(13, 13);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(334, 238);
            this.lstData.TabIndex = 0;
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(13, 268);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(145, 27);
            this.btnEven.TabIndex = 1;
            this.btnEven.Text = "Even";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnLinQ
            // 
            this.btnLinQ.Location = new System.Drawing.Point(13, 301);
            this.btnLinQ.Name = "btnLinQ";
            this.btnLinQ.Size = new System.Drawing.Size(145, 27);
            this.btnLinQ.TabIndex = 2;
            this.btnLinQ.Text = "EvenLinQ";
            this.btnLinQ.UseVisualStyleBackColor = true;
            this.btnLinQ.Click += new System.EventHandler(this.btnLinQ_Click);
            // 
            // btnFindVardenis
            // 
            this.btnFindVardenis.Location = new System.Drawing.Point(164, 268);
            this.btnFindVardenis.Name = "btnFindVardenis";
            this.btnFindVardenis.Size = new System.Drawing.Size(145, 27);
            this.btnFindVardenis.TabIndex = 3;
            this.btnFindVardenis.Text = "Find vardenis";
            this.btnFindVardenis.UseVisualStyleBackColor = true;
            this.btnFindVardenis.Click += new System.EventHandler(this.btnFindVardenis_Click);
            // 
            // btnFindLinQ
            // 
            this.btnFindLinQ.Location = new System.Drawing.Point(164, 301);
            this.btnFindLinQ.Name = "btnFindLinQ";
            this.btnFindLinQ.Size = new System.Drawing.Size(145, 27);
            this.btnFindLinQ.TabIndex = 4;
            this.btnFindLinQ.Text = "FindLinQ";
            this.btnFindLinQ.UseVisualStyleBackColor = true;
            this.btnFindLinQ.Click += new System.EventHandler(this.btnFindLinQ_Click);
            // 
            // btnSortList
            // 
            this.btnSortList.Location = new System.Drawing.Point(315, 268);
            this.btnSortList.Name = "btnSortList";
            this.btnSortList.Size = new System.Drawing.Size(145, 27);
            this.btnSortList.TabIndex = 5;
            this.btnSortList.Text = "Sort list";
            this.btnSortList.UseVisualStyleBackColor = true;
            this.btnSortList.Click += new System.EventHandler(this.btnSortList_Click);
            // 
            // btnShowOnlyProp
            // 
            this.btnShowOnlyProp.Location = new System.Drawing.Point(315, 301);
            this.btnShowOnlyProp.Name = "btnShowOnlyProp";
            this.btnShowOnlyProp.Size = new System.Drawing.Size(145, 27);
            this.btnShowOnlyProp.TabIndex = 6;
            this.btnShowOnlyProp.Text = "Show Only";
            this.btnShowOnlyProp.UseVisualStyleBackColor = true;
            this.btnShowOnlyProp.Click += new System.EventHandler(this.btnShowOnlyProp_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(13, 334);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(145, 27);
            this.btnJoin.TabIndex = 7;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnShowOnlyProp);
            this.Controls.Add(this.btnSortList);
            this.Controls.Add(this.btnFindLinQ);
            this.Controls.Add(this.btnFindVardenis);
            this.Controls.Add(this.btnLinQ);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.lstData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnLinQ;
        private System.Windows.Forms.Button btnFindVardenis;
        private System.Windows.Forms.Button btnFindLinQ;
        private System.Windows.Forms.Button btnSortList;
        private System.Windows.Forms.Button btnShowOnlyProp;
        private System.Windows.Forms.Button btnJoin;
    }
}

