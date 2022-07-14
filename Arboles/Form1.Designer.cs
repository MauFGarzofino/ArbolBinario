namespace Arboles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.raizbox = new System.Windows.Forms.TextBox();
            this.hijo = new System.Windows.Forms.TextBox();
            this.padre = new System.Windows.Forms.TextBox();
            this.dsa = new System.Windows.Forms.Button();
            this.InsertarIzquierda = new System.Windows.Forms.Button();
            this.InsertarDerecha = new System.Windows.Forms.Button();
            this.EliminarDerecha = new System.Windows.Forms.Button();
            this.EliminarIzquierda = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.entreorden = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ordenLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // raizbox
            // 
            this.raizbox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.raizbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raizbox.Location = new System.Drawing.Point(366, 42);
            this.raizbox.Name = "raizbox";
            this.raizbox.Size = new System.Drawing.Size(190, 22);
            this.raizbox.TabIndex = 1;
            this.raizbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hijo
            // 
            this.hijo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.hijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hijo.Location = new System.Drawing.Point(400, 103);
            this.hijo.Name = "hijo";
            this.hijo.Size = new System.Drawing.Size(152, 22);
            this.hijo.TabIndex = 2;
            this.hijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // padre
            // 
            this.padre.BackColor = System.Drawing.Color.PaleTurquoise;
            this.padre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.padre.Location = new System.Drawing.Point(207, 103);
            this.padre.Name = "padre";
            this.padre.Size = new System.Drawing.Size(152, 22);
            this.padre.TabIndex = 3;
            this.padre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dsa
            // 
            this.dsa.BackColor = System.Drawing.Color.SkyBlue;
            this.dsa.Location = new System.Drawing.Point(203, 32);
            this.dsa.Name = "dsa";
            this.dsa.Size = new System.Drawing.Size(137, 46);
            this.dsa.TabIndex = 4;
            this.dsa.Text = "Insertar Raiz";
            this.dsa.UseVisualStyleBackColor = false;
            this.dsa.Click += new System.EventHandler(this.dsa_Click);
            // 
            // InsertarIzquierda
            // 
            this.InsertarIzquierda.BackColor = System.Drawing.Color.SkyBlue;
            this.InsertarIzquierda.Location = new System.Drawing.Point(207, 131);
            this.InsertarIzquierda.Name = "InsertarIzquierda";
            this.InsertarIzquierda.Size = new System.Drawing.Size(152, 46);
            this.InsertarIzquierda.TabIndex = 5;
            this.InsertarIzquierda.Text = "InsertarIzquierda";
            this.InsertarIzquierda.UseVisualStyleBackColor = false;
            this.InsertarIzquierda.Click += new System.EventHandler(this.InsertarIzquierda_Click);
            // 
            // InsertarDerecha
            // 
            this.InsertarDerecha.BackColor = System.Drawing.Color.SkyBlue;
            this.InsertarDerecha.Location = new System.Drawing.Point(400, 131);
            this.InsertarDerecha.Name = "InsertarDerecha";
            this.InsertarDerecha.Size = new System.Drawing.Size(156, 46);
            this.InsertarDerecha.TabIndex = 6;
            this.InsertarDerecha.Text = "InsertarDerecha";
            this.InsertarDerecha.UseVisualStyleBackColor = false;
            this.InsertarDerecha.Click += new System.EventHandler(this.InsertarDerecha_Click);
            // 
            // EliminarDerecha
            // 
            this.EliminarDerecha.BackColor = System.Drawing.Color.SkyBlue;
            this.EliminarDerecha.Location = new System.Drawing.Point(400, 183);
            this.EliminarDerecha.Name = "EliminarDerecha";
            this.EliminarDerecha.Size = new System.Drawing.Size(156, 46);
            this.EliminarDerecha.TabIndex = 7;
            this.EliminarDerecha.Text = "EliminarDerecha";
            this.EliminarDerecha.UseVisualStyleBackColor = false;
            this.EliminarDerecha.Click += new System.EventHandler(this.EliminarDerecha_Click);
            // 
            // EliminarIzquierda
            // 
            this.EliminarIzquierda.BackColor = System.Drawing.Color.SkyBlue;
            this.EliminarIzquierda.Location = new System.Drawing.Point(207, 183);
            this.EliminarIzquierda.Name = "EliminarIzquierda";
            this.EliminarIzquierda.Size = new System.Drawing.Size(156, 46);
            this.EliminarIzquierda.TabIndex = 8;
            this.EliminarIzquierda.Text = "EliminarIzquierda";
            this.EliminarIzquierda.UseVisualStyleBackColor = false;
            this.EliminarIzquierda.Click += new System.EventHandler(this.EliminarIzquierda_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Location = new System.Drawing.Point(203, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 46);
            this.button6.TabIndex = 9;
            this.button6.Text = "Pre-Orden";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // entreorden
            // 
            this.entreorden.BackColor = System.Drawing.Color.SkyBlue;
            this.entreorden.Location = new System.Drawing.Point(203, 321);
            this.entreorden.Name = "entreorden";
            this.entreorden.Size = new System.Drawing.Size(156, 46);
            this.entreorden.TabIndex = 10;
            this.entreorden.Text = "Entre-Orden";
            this.entreorden.UseVisualStyleBackColor = false;
            this.entreorden.Click += new System.EventHandler(this.entreorden_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SkyBlue;
            this.button8.Location = new System.Drawing.Point(203, 373);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(156, 46);
            this.button8.TabIndex = 11;
            this.button8.Text = "Pos-Orden";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // ordenLabel
            // 
            this.ordenLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ordenLabel.Location = new System.Drawing.Point(412, 314);
            this.ordenLabel.Name = "ordenLabel";
            this.ordenLabel.Size = new System.Drawing.Size(246, 61);
            this.ordenLabel.TabIndex = 12;
            this.ordenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(509, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Recorrido";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(787, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordenLabel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.entreorden);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.EliminarIzquierda);
            this.Controls.Add(this.EliminarDerecha);
            this.Controls.Add(this.InsertarDerecha);
            this.Controls.Add(this.InsertarIzquierda);
            this.Controls.Add(this.dsa);
            this.Controls.Add(this.padre);
            this.Controls.Add(this.hijo);
            this.Controls.Add(this.raizbox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox raizbox;
        private System.Windows.Forms.TextBox hijo;
        private System.Windows.Forms.TextBox padre;
        private System.Windows.Forms.Button dsa;
        private System.Windows.Forms.Button InsertarIzquierda;
        private System.Windows.Forms.Button InsertarDerecha;
        private System.Windows.Forms.Button EliminarDerecha;
        private System.Windows.Forms.Button EliminarIzquierda;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button entreorden;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label ordenLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

