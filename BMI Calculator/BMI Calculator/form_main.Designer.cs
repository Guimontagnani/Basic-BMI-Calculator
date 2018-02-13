namespace BMI_Calculator
{
    partial class form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txb_altura = new System.Windows.Forms.TextBox();
            this.txb_peso = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txb_res = new System.Windows.Forms.TextBox();
            this.txb_english = new System.Windows.Forms.TextBox();
            this.lbl_explain = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_eng = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(32, 46);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(38, 13);
            this.lbl_height.TabIndex = 0;
            this.lbl_height.Text = "Height";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(32, 96);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(41, 13);
            this.lbl_weight.TabIndex = 1;
            this.lbl_weight.Text = "Weight";
            // 
            // txb_altura
            // 
            this.txb_altura.Location = new System.Drawing.Point(32, 66);
            this.txb_altura.Name = "txb_altura";
            this.txb_altura.Size = new System.Drawing.Size(119, 20);
            this.txb_altura.TabIndex = 2;
            // 
            // txb_peso
            // 
            this.txb_peso.Location = new System.Drawing.Point(32, 116);
            this.txb_peso.Name = "txb_peso";
            this.txb_peso.Size = new System.Drawing.Size(119, 20);
            this.txb_peso.TabIndex = 3;
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_calc.Font = new System.Drawing.Font("Helvetica LT Std Cond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_calc.Location = new System.Drawing.Point(184, 77);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(79, 61);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // txb_res
            // 
            this.txb_res.Location = new System.Drawing.Point(34, 186);
            this.txb_res.Name = "txb_res";
            this.txb_res.Size = new System.Drawing.Size(229, 20);
            this.txb_res.TabIndex = 5;
            // 
            // txb_english
            // 
            this.txb_english.Location = new System.Drawing.Point(35, 222);
            this.txb_english.Name = "txb_english";
            this.txb_english.Size = new System.Drawing.Size(228, 20);
            this.txb_english.TabIndex = 6;
            // 
            // lbl_explain
            // 
            this.lbl_explain.BackColor = System.Drawing.Color.Transparent;
            this.lbl_explain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_explain.Font = new System.Drawing.Font("Helvetica LT Std", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_explain.Location = new System.Drawing.Point(12, 9);
            this.lbl_explain.Name = "lbl_explain";
            this.lbl_explain.Size = new System.Drawing.Size(264, 37);
            this.lbl_explain.TabIndex = 7;
            this.lbl_explain.Text = "Insert values in boxes and press calculate to know your BMI";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.BackColor = System.Drawing.Color.Transparent;
            this.lbl_port.Font = new System.Drawing.Font("Helvetica LT Std Black", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_port.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbl_port.Location = new System.Drawing.Point(38, 175);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(74, 14);
            this.lbl_port.TabIndex = 8;
            this.lbl_port.Text = "Portuguese";
            // 
            // lbl_eng
            // 
            this.lbl_eng.AutoSize = true;
            this.lbl_eng.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eng.Font = new System.Drawing.Font("Helvetica LT Std Black", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eng.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbl_eng.Location = new System.Drawing.Point(35, 209);
            this.lbl_eng.Name = "lbl_eng";
            this.lbl_eng.Size = new System.Drawing.Size(51, 14);
            this.lbl_eng.TabIndex = 9;
            this.lbl_eng.Text = "English";
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(279, 258);
            this.Controls.Add(this.lbl_eng);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.lbl_explain);
            this.Controls.Add(this.txb_english);
            this.Controls.Add(this.txb_res);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txb_peso);
            this.Controls.Add(this.txb_altura);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_height);
            this.Name = "form_main";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.TextBox txb_altura;
        private System.Windows.Forms.TextBox txb_peso;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox txb_res;
        private System.Windows.Forms.TextBox txb_english;
        private System.Windows.Forms.Label lbl_explain;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_eng;
    }
}

