
namespace Player01
{
    partial class AddPlayList
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.albumArtPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.albumArtTextBox = new System.Windows.Forms.TextBox();
            this.mp3PathTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.mp3PathLabel = new System.Windows.Forms.Label();
            this.albumArtPathLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.browseMp3Button = new System.Windows.Forms.Button();
            this.browseAlbumArtButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openMp3FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openAlbumArtFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 10.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(546, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Close_Btn);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 10.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(462, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "—";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 10.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(504, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "☐";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // albumArtPicture
            // 
            this.albumArtPicture.BackgroundImage = global::Player01.Properties.Resources.no_album_art;
            this.albumArtPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumArtPicture.Location = new System.Drawing.Point(167, 21);
            this.albumArtPicture.Name = "albumArtPicture";
            this.albumArtPicture.Size = new System.Drawing.Size(224, 192);
            this.albumArtPicture.TabIndex = 12;
            this.albumArtPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "(optional)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // albumArtTextBox
            // 
            this.albumArtTextBox.Location = new System.Drawing.Point(101, 363);
            this.albumArtTextBox.Name = "albumArtTextBox";
            this.albumArtTextBox.Size = new System.Drawing.Size(287, 20);
            this.albumArtTextBox.TabIndex = 7;
            this.albumArtTextBox.WordWrap = false;
            this.albumArtTextBox.TextChanged += new System.EventHandler(this.AlbumArtTextBox_TextChanged);
            // 
            // mp3PathTextBox
            // 
            this.mp3PathTextBox.Location = new System.Drawing.Point(104, 318);
            this.mp3PathTextBox.Name = "mp3PathTextBox";
            this.mp3PathTextBox.Size = new System.Drawing.Size(287, 20);
            this.mp3PathTextBox.TabIndex = 6;
            this.mp3PathTextBox.WordWrap = false;
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(104, 271);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(368, 20);
            this.artistTextBox.TabIndex = 5;
            this.artistTextBox.WordWrap = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(34, 236);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.ForeColor = System.Drawing.Color.White;
            this.artistLabel.Location = new System.Drawing.Point(34, 278);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(36, 13);
            this.artistLabel.TabIndex = 1;
            this.artistLabel.Text = "Artist";
            this.artistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mp3PathLabel
            // 
            this.mp3PathLabel.AutoSize = true;
            this.mp3PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp3PathLabel.ForeColor = System.Drawing.Color.White;
            this.mp3PathLabel.Location = new System.Drawing.Point(34, 315);
            this.mp3PathLabel.Name = "mp3PathLabel";
            this.mp3PathLabel.Size = new System.Drawing.Size(64, 13);
            this.mp3PathLabel.TabIndex = 2;
            this.mp3PathLabel.Text = "Music File";
            this.mp3PathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // albumArtPathLabel
            // 
            this.albumArtPathLabel.AutoSize = true;
            this.albumArtPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumArtPathLabel.ForeColor = System.Drawing.Color.White;
            this.albumArtPathLabel.Location = new System.Drawing.Point(34, 360);
            this.albumArtPathLabel.Name = "albumArtPathLabel";
            this.albumArtPathLabel.Size = new System.Drawing.Size(61, 13);
            this.albumArtPathLabel.TabIndex = 3;
            this.albumArtPathLabel.Text = "Album Art";
            this.albumArtPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(104, 236);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(368, 20);
            this.titleTextBox.TabIndex = 4;
            this.titleTextBox.WordWrap = false;
            // 
            // browseMp3Button
            // 
            this.browseMp3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browseMp3Button.FlatAppearance.BorderSize = 0;
            this.browseMp3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseMp3Button.ForeColor = System.Drawing.Color.White;
            this.browseMp3Button.Location = new System.Drawing.Point(397, 315);
            this.browseMp3Button.Name = "browseMp3Button";
            this.browseMp3Button.Size = new System.Drawing.Size(75, 23);
            this.browseMp3Button.TabIndex = 8;
            this.browseMp3Button.Text = "Browse...";
            this.browseMp3Button.UseVisualStyleBackColor = false;
            this.browseMp3Button.Click += new System.EventHandler(this.PickMusic_Btn);
            // 
            // browseAlbumArtButton
            // 
            this.browseAlbumArtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browseAlbumArtButton.FlatAppearance.BorderSize = 0;
            this.browseAlbumArtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAlbumArtButton.ForeColor = System.Drawing.Color.White;
            this.browseAlbumArtButton.Location = new System.Drawing.Point(397, 361);
            this.browseAlbumArtButton.Name = "browseAlbumArtButton";
            this.browseAlbumArtButton.Size = new System.Drawing.Size(75, 23);
            this.browseAlbumArtButton.TabIndex = 9;
            this.browseAlbumArtButton.Text = "Browse...";
            this.browseAlbumArtButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(397, 407);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(316, 407);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // openMp3FileDialog
            // 
            this.openMp3FileDialog.DefaultExt = "mp3";
            this.openMp3FileDialog.Filter = "MP3 or WAV Files|*.mp3;*.wav";
            // 
            // openAlbumArtFileDialog
            // 
            this.openAlbumArtFileDialog.Filter = "Image Files|*.jpg;*.png;*.gif;*.jpeg";
            // 
            // AddPlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(590, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumArtTextBox);
            this.Controls.Add(this.albumArtPicture);
            this.Controls.Add(this.albumArtPathLabel);
            this.Controls.Add(this.browseAlbumArtButton);
            this.Controls.Add(this.mp3PathTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseMp3Button);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mp3PathLabel);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.titleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPlayList";
            this.Text = "AddPlayList";
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox albumArtPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox albumArtTextBox;
        private System.Windows.Forms.TextBox mp3PathTextBox;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label mp3PathLabel;
        private System.Windows.Forms.Label albumArtPathLabel;
        private System.Windows.Forms.Button browseMp3Button;
        private System.Windows.Forms.Button browseAlbumArtButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.OpenFileDialog openMp3FileDialog;
        private System.Windows.Forms.OpenFileDialog openAlbumArtFileDialog;
    }
}