namespace Assignment_8
{
    partial class OnCampusTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnCampusTickets));
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.EventLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.musicalButton = new System.Windows.Forms.Button();
            this.basketButton = new System.Windows.Forms.Button();
            this.playbutton = new System.Windows.Forms.Button();
            this.txtcustomerName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.chosenEventlabel = new System.Windows.Forms.Label();
            this.txtChosenEvent = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.Snow;
            this.CustomerNameLabel.Location = new System.Drawing.Point(84, 293);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(181, 18);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Enter Customer Name:";
            this.CustomerNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuantityLabel.Location = new System.Drawing.Point(76, 336);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(189, 18);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "Enter amount of tickets:";
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EventLabel.Location = new System.Drawing.Point(214, 30);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(176, 24);
            this.EventLabel.TabIndex = 2;
            this.EventLabel.Text = "Choose an Event ";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // musicalButton
            // 
            this.musicalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musicalButton.BackgroundImage")));
            this.musicalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.musicalButton.Location = new System.Drawing.Point(44, 75);
            this.musicalButton.Name = "musicalButton";
            this.musicalButton.Size = new System.Drawing.Size(144, 135);
            this.musicalButton.TabIndex = 3;
            this.musicalButton.UseVisualStyleBackColor = true;
            this.musicalButton.Click += new System.EventHandler(this.musicalButton_Click);
            // 
            // basketButton
            // 
            this.basketButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basketButton.BackgroundImage")));
            this.basketButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.basketButton.Location = new System.Drawing.Point(227, 75);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(143, 135);
            this.basketButton.TabIndex = 4;
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // playbutton
            // 
            this.playbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playbutton.BackgroundImage")));
            this.playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playbutton.Location = new System.Drawing.Point(409, 75);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(137, 135);
            this.playbutton.TabIndex = 5;
            this.playbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playbutton.UseVisualStyleBackColor = true;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // txtcustomerName
            // 
            this.txtcustomerName.Location = new System.Drawing.Point(270, 294);
            this.txtcustomerName.Name = "txtcustomerName";
            this.txtcustomerName.Size = new System.Drawing.Size(176, 20);
            this.txtcustomerName.TabIndex = 6;
            this.txtcustomerName.TextChanged += new System.EventHandler(this.txtcustomerName_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(270, 337);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // chosenEventlabel
            // 
            this.chosenEventlabel.AutoSize = true;
            this.chosenEventlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenEventlabel.ForeColor = System.Drawing.Color.Snow;
            this.chosenEventlabel.Location = new System.Drawing.Point(142, 246);
            this.chosenEventlabel.Name = "chosenEventlabel";
            this.chosenEventlabel.Size = new System.Drawing.Size(118, 18);
            this.chosenEventlabel.TabIndex = 8;
            this.chosenEventlabel.Text = "Event Chosen:";
            // 
            // txtChosenEvent
            // 
            this.txtChosenEvent.Location = new System.Drawing.Point(270, 247);
            this.txtChosenEvent.Name = "txtChosenEvent";
            this.txtChosenEvent.Size = new System.Drawing.Size(100, 20);
            this.txtChosenEvent.TabIndex = 9;
            this.txtChosenEvent.TextChanged += new System.EventHandler(this.txtChosenEvent_TextChanged);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CostLabel.Location = new System.Drawing.Point(93, 395);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(44, 18);
            this.CostLabel.TabIndex = 10;
            this.CostLabel.Text = "Cost";
            this.CostLabel.Click += new System.EventHandler(this.CostLabel_Click);
            // 
            // OnCampusTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(605, 515);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.txtChosenEvent);
            this.Controls.Add(this.chosenEventlabel);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtcustomerName);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.basketButton);
            this.Controls.Add(this.musicalButton);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Name = "OnCampusTickets";
            this.Text = "UFC Tickets Sale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button musicalButton;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.TextBox txtcustomerName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label chosenEventlabel;
        private System.Windows.Forms.TextBox txtChosenEvent;
        private System.Windows.Forms.Label CostLabel;
    }
}

