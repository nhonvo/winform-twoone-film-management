namespace MovieWinform.GUI.Forms
{
    partial class FrmFaceID
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.picCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(972, 400);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(894, 400);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(882, 104);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(164, 28);
            this.btnAddPerson.TabIndex = 18;
            this.btnAddPerson.Text = "3. Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(882, 138);
            this.picDetected.Margin = new System.Windows.Forms.Padding(4);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(164, 151);
            this.picDetected.TabIndex = 17;
            this.picDetected.TabStop = false;
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(883, 365);
            this.btnRecognize.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(163, 28);
            this.btnRecognize.TabIndex = 16;
            this.btnRecognize.Text = "5. Recognize Persons";
            this.btnRecognize.UseVisualStyleBackColor = true;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(883, 329);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(163, 28);
            this.btnTrain.TabIndex = 15;
            this.btnTrain.Text = "4. Train Images";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(883, 297);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(161, 22);
            this.txtPersonName.TabIndex = 14;
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.Location = new System.Drawing.Point(882, 67);
            this.btnDetectFaces.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(164, 28);
            this.btnDetectFaces.TabIndex = 13;
            this.btnDetectFaces.Text = "2. Detect Faces";
            this.btnDetectFaces.UseVisualStyleBackColor = true;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(882, 30);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(164, 28);
            this.btnCapture.TabIndex = 12;
            this.btnCapture.Text = "1. Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(2, 21);
            this.picCapture.Margin = new System.Windows.Forms.Padding(4);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(871, 537);
            this.picCapture.TabIndex = 11;
            this.picCapture.TabStop = false;
            // 
            // FrmFaceID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 579);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.btnDetectFaces);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picCapture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFaceID";
            this.Text = "FrmFaceID";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.PictureBox picDetected;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button btnDetectFaces;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox picCapture;
    }
}