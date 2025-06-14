namespace IMC_FORM
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
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.lblSancada = new System.Windows.Forms.Label();
            this.txtZancada = new System.Windows.Forms.TextBox();
            this.btbCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(173, 45);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(125, 16);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Calculadora de IMC";
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(37, 106);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(157, 16);
            this.lblIMC.TabIndex = 1;
            this.lblIMC.Text = "Introduce tu peso (En kg):";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(40, 150);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(155, 22);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Location = new System.Drawing.Point(40, 212);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(170, 16);
            this.lblEstatura.TabIndex = 3;
            this.lblEstatura.Text = "Introduce tu estatura (En m):";
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(40, 252);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(170, 22);
            this.txtEstatura.TabIndex = 4;
            this.txtEstatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstatura_KeyPress);
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(43, 312);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(303, 16);
            this.lblPasos.TabIndex = 5;
            this.lblPasos.Text = "Introduce la cantidad de pasos que das en un día:";
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(40, 358);
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(306, 22);
            this.txtPasos.TabIndex = 6;
            this.txtPasos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasos_KeyPress);
            // 
            // lblSancada
            // 
            this.lblSancada.AutoSize = true;
            this.lblSancada.Location = new System.Drawing.Point(40, 413);
            this.lblSancada.Name = "lblSancada";
            this.lblSancada.Size = new System.Drawing.Size(262, 16);
            this.lblSancada.TabIndex = 7;
            this.lblSancada.Text = "Introduce el tamaño de tu zancada (En cm):";
            // 
            // txtZancada
            // 
            this.txtZancada.Location = new System.Drawing.Point(40, 461);
            this.txtZancada.Name = "txtZancada";
            this.txtZancada.Size = new System.Drawing.Size(258, 22);
            this.txtZancada.TabIndex = 8;
            this.txtZancada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZancada_KeyPress);
            // 
            // btbCalc
            // 
            this.btbCalc.Location = new System.Drawing.Point(188, 533);
            this.btbCalc.Name = "btbCalc";
            this.btbCalc.Size = new System.Drawing.Size(75, 23);
            this.btbCalc.TabIndex = 9;
            this.btbCalc.Text = "Calcular";
            this.btbCalc.UseVisualStyleBackColor = true;
            this.btbCalc.Click += new System.EventHandler(this.btbCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.btbCalc);
            this.Controls.Add(this.txtZancada);
            this.Controls.Add(this.lblSancada);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblIntro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Label lblSancada;
        private System.Windows.Forms.TextBox txtZancada;
        private System.Windows.Forms.Button btbCalc;
    }
}

