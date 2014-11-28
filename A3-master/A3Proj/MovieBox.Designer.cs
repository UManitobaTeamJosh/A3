namespace A3Proj {
    partial class MovieBox {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieBox));
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.movieImage = new System.Windows.Forms.PictureBox();
            this.labelMovieYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(2, 166);
            this.labelMovieTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(59, 13);
            this.labelMovieTitle.TabIndex = 0;
            this.labelMovieTitle.Text = "Movie Title";
            // 
            // movieImage
            // 
            this.movieImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.movieImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("movieImage.BackgroundImage")));
            this.movieImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movieImage.Location = new System.Drawing.Point(2, 2);
            this.movieImage.Margin = new System.Windows.Forms.Padding(2);
            this.movieImage.Name = "movieImage";
            this.movieImage.Size = new System.Drawing.Size(140, 161);
            this.movieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movieImage.TabIndex = 1;
            this.movieImage.TabStop = false;
            // 
            // labelMovieYear
            // 
            this.labelMovieYear.AutoSize = true;
            this.labelMovieYear.Location = new System.Drawing.Point(4, 183);
            this.labelMovieYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMovieYear.Name = "labelMovieYear";
            this.labelMovieYear.Size = new System.Drawing.Size(35, 13);
            this.labelMovieYear.TabIndex = 2;
            this.labelMovieYear.Text = "####";
            // 
            // MovieBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMovieYear);
            this.Controls.Add(this.movieImage);
            this.Controls.Add(this.labelMovieTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MovieBox";
            this.Size = new System.Drawing.Size(143, 224);
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.PictureBox movieImage;
        private System.Windows.Forms.Label labelMovieYear;

    }
}
