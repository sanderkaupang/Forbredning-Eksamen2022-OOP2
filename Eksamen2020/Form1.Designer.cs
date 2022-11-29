namespace ia2112_sp_v2020
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveFromStack = new System.Windows.Forms.Button();
            this.btnDeleteAllShapes = new System.Windows.Forms.Button();
            this.btnShowRandomShape = new System.Windows.Forms.Button();
            this.picShape = new System.Windows.Forms.PictureBox();
            this.tmrShowShapes = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShape)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 16);
            this.label8.TabIndex = 96;
            this.label8.Text = "er delelig med 5. En messagebox skal da vises.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 16);
            this.label7.TabIndex = 95;
            this.label7.Text = "Event skal inntreffe hvis antall figurer på stack";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(339, 30);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(47, 22);
            this.txtNumber.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 93;
            this.label5.Text = "Antall på stack:";
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(585, 73);
            this.txtShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(237, 245);
            this.txtShow.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(581, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 91;
            this.label4.Text = "Figur:";
            // 
            // btnRemoveFromStack
            // 
            this.btnRemoveFromStack.Location = new System.Drawing.Point(32, 111);
            this.btnRemoveFromStack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveFromStack.Name = "btnRemoveFromStack";
            this.btnRemoveFromStack.Size = new System.Drawing.Size(173, 32);
            this.btnRemoveFromStack.TabIndex = 90;
            this.btnRemoveFromStack.Text = "Fjern siste figur fra stack";
            this.btnRemoveFromStack.UseVisualStyleBackColor = true;
            this.btnRemoveFromStack.Click += new System.EventHandler(this.btnRemoveFromStack_Click);
            // 
            // btnDeleteAllShapes
            // 
            this.btnDeleteAllShapes.Location = new System.Drawing.Point(224, 113);
            this.btnDeleteAllShapes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteAllShapes.Name = "btnDeleteAllShapes";
            this.btnDeleteAllShapes.Size = new System.Drawing.Size(193, 30);
            this.btnDeleteAllShapes.TabIndex = 89;
            this.btnDeleteAllShapes.Text = "Slett alle figurer fra stack";
            this.btnDeleteAllShapes.UseVisualStyleBackColor = true;
            this.btnDeleteAllShapes.Click += new System.EventHandler(this.btnDeleteAllShapes_Click);
            // 
            // btnShowRandomShape
            // 
            this.btnShowRandomShape.Location = new System.Drawing.Point(33, 30);
            this.btnShowRandomShape.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowRandomShape.Name = "btnShowRandomShape";
            this.btnShowRandomShape.Size = new System.Drawing.Size(173, 54);
            this.btnShowRandomShape.TabIndex = 88;
            this.btnShowRandomShape.Text = "Lag og vis tilfeldig figur. Legg figur på stack.";
            this.btnShowRandomShape.UseVisualStyleBackColor = true;
            this.btnShowRandomShape.Click += new System.EventHandler(this.btnShowRandomShape_Click);
            // 
            // picShape
            // 
            this.picShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShape.Location = new System.Drawing.Point(32, 159);
            this.picShape.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picShape.Name = "picShape";
            this.picShape.Size = new System.Drawing.Size(173, 160);
            this.picShape.TabIndex = 87;
            this.picShape.TabStop = false;
            // 
            // tmrShowShapes
            // 
            this.tmrShowShapes.Interval = 1000;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(711, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 100;
            this.label10.Text = "Areal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(641, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 99;
            this.label9.Text = "Side:";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(475, 294);
            this.txtSide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSide.Name = "txtSide";
            this.txtSide.ReadOnly = true;
            this.txtSide.Size = new System.Drawing.Size(81, 22);
            this.txtSide.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "Randomgenerert tall for sidebredde:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 364);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRemoveFromStack);
            this.Controls.Add(this.btnDeleteAllShapes);
            this.Controls.Add(this.btnShowRandomShape);
            this.Controls.Add(this.picShape);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSide);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picShape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveFromStack;
        private System.Windows.Forms.Button btnDeleteAllShapes;
        private System.Windows.Forms.Button btnShowRandomShape;
        private System.Windows.Forms.PictureBox picShape;
        private System.Windows.Forms.Timer tmrShowShapes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label label3;
    }
}

