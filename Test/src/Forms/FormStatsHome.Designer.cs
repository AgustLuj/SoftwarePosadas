namespace Program.Forms
{
  partial class FormStatsHome
  {

    private System.ComponentModel.IContainer components = null;
    
    
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    
    private void InitializeComponent()
    {
    	this.check_dia = new MaterialSkin.Controls.MaterialCheckBox();
    	this.combo_dia = new System.Windows.Forms.ComboBox();
    	this.check_mes = new MaterialSkin.Controls.MaterialCheckBox();
    	this.check_año = new MaterialSkin.Controls.MaterialCheckBox();
    	this.combo_mes = new System.Windows.Forms.ComboBox();
    	this.combo_año = new System.Windows.Forms.ComboBox();
    	this.radio_personalizado = new MaterialSkin.Controls.MaterialRadioButton();
    	this.radio_historico = new MaterialSkin.Controls.MaterialRadioButton();
    	this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
    	this.button_origin = new MaterialSkin.Controls.MaterialFlatButton();
    	this.SuspendLayout();
    	// 
    	// check_dia
    	// 
    	this.check_dia.Depth = 0;
    	this.check_dia.Font = new System.Drawing.Font("Roboto", 10F);
    	this.check_dia.Location = new System.Drawing.Point(426, 171);
    	this.check_dia.Margin = new System.Windows.Forms.Padding(0);
    	this.check_dia.MouseLocation = new System.Drawing.Point(-1, -1);
    	this.check_dia.MouseState = MaterialSkin.MouseState.HOVER;
    	this.check_dia.Name = "check_dia";
    	this.check_dia.Ripple = true;
    	this.check_dia.Size = new System.Drawing.Size(60, 24);
    	this.check_dia.TabIndex = 45;
    	this.check_dia.Text = "Dia";
    	this.check_dia.UseVisualStyleBackColor = true;
    	// 
    	// combo_dia
    	// 
    	this.combo_dia.Enabled = false;
    	this.combo_dia.FormattingEnabled = true;
    	this.combo_dia.Location = new System.Drawing.Point(489, 172);
    	this.combo_dia.Name = "combo_dia";
    	this.combo_dia.Size = new System.Drawing.Size(121, 21);
    	this.combo_dia.TabIndex = 44;
    	// 
    	// check_mes
    	// 
    	this.check_mes.Depth = 0;
    	this.check_mes.Font = new System.Drawing.Font("Roboto", 10F);
    	this.check_mes.Location = new System.Drawing.Point(426, 143);
    	this.check_mes.Margin = new System.Windows.Forms.Padding(0);
    	this.check_mes.MouseLocation = new System.Drawing.Point(-1, -1);
    	this.check_mes.MouseState = MaterialSkin.MouseState.HOVER;
    	this.check_mes.Name = "check_mes";
    	this.check_mes.Ripple = true;
    	this.check_mes.Size = new System.Drawing.Size(60, 24);
    	this.check_mes.TabIndex = 43;
    	this.check_mes.Text = "Mes";
    	this.check_mes.UseVisualStyleBackColor = true;
    	// 
    	// check_año
    	// 
    	this.check_año.Depth = 0;
    	this.check_año.Font = new System.Drawing.Font("Roboto", 10F);
    	this.check_año.Location = new System.Drawing.Point(426, 115);
    	this.check_año.Margin = new System.Windows.Forms.Padding(0);
    	this.check_año.MouseLocation = new System.Drawing.Point(-1, -1);
    	this.check_año.MouseState = MaterialSkin.MouseState.HOVER;
    	this.check_año.Name = "check_año";
    	this.check_año.Ripple = true;
    	this.check_año.Size = new System.Drawing.Size(60, 24);
    	this.check_año.TabIndex = 42;
    	this.check_año.Text = "Año";
    	this.check_año.UseVisualStyleBackColor = true;
    	// 
    	// combo_mes
    	// 
    	this.combo_mes.Enabled = false;
    	this.combo_mes.FormattingEnabled = true;
    	this.combo_mes.Items.AddRange(new object[] {
    	    	    	"Enero",
    	    	    	"Febrero",
    	    	    	"Marzo",
    	    	    	"Abril",
    	    	    	"Mayo",
    	    	    	"Junio",
    	    	    	"Julio",
    	    	    	"Agosto",
    	    	    	"Septiembre",
    	    	    	"Octubre",
    	    	    	"Noviembre",
    	    	    	"Diciembre"});
    	this.combo_mes.Location = new System.Drawing.Point(489, 144);
    	this.combo_mes.Name = "combo_mes";
    	this.combo_mes.Size = new System.Drawing.Size(121, 21);
    	this.combo_mes.TabIndex = 41;
    	// 
    	// combo_año
    	// 
    	this.combo_año.Enabled = false;
    	this.combo_año.FormattingEnabled = true;
    	this.combo_año.Location = new System.Drawing.Point(489, 116);
    	this.combo_año.Name = "combo_año";
    	this.combo_año.Size = new System.Drawing.Size(121, 21);
    	this.combo_año.TabIndex = 40;
    	// 
    	// radio_personalizado
    	// 
    	this.radio_personalizado.Depth = 0;
    	this.radio_personalizado.Font = new System.Drawing.Font("Roboto", 10F);
    	this.radio_personalizado.Location = new System.Drawing.Point(269, 138);
    	this.radio_personalizado.Margin = new System.Windows.Forms.Padding(0);
    	this.radio_personalizado.MouseLocation = new System.Drawing.Point(-1, -1);
    	this.radio_personalizado.MouseState = MaterialSkin.MouseState.HOVER;
    	this.radio_personalizado.Name = "radio_personalizado";
    	this.radio_personalizado.Ripple = true;
    	this.radio_personalizado.Size = new System.Drawing.Size(184, 30);
    	this.radio_personalizado.TabIndex = 39;
    	this.radio_personalizado.TabStop = true;
    	this.radio_personalizado.Text = "Personalizado";
    	this.radio_personalizado.UseVisualStyleBackColor = true;
    	// 
    	// radio_historico
    	// 
    	this.radio_historico.Depth = 0;
    	this.radio_historico.Font = new System.Drawing.Font("Roboto", 10F);
    	this.radio_historico.Location = new System.Drawing.Point(269, 111);
    	this.radio_historico.Margin = new System.Windows.Forms.Padding(0);
    	this.radio_historico.MouseLocation = new System.Drawing.Point(-1, -1);
    	this.radio_historico.MouseState = MaterialSkin.MouseState.HOVER;
    	this.radio_historico.Name = "radio_historico";
    	this.radio_historico.Ripple = true;
    	this.radio_historico.Size = new System.Drawing.Size(184, 30);
    	this.radio_historico.TabIndex = 38;
    	this.radio_historico.TabStop = true;
    	this.radio_historico.Text = "Histórico";
    	this.radio_historico.UseVisualStyleBackColor = true;
    	// 
    	// materialLabel2
    	// 
    	this.materialLabel2.Depth = 0;
    	this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
    	this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
    	this.materialLabel2.Location = new System.Drawing.Point(268, 87);
    	this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
    	this.materialLabel2.Name = "materialLabel2";
    	this.materialLabel2.Size = new System.Drawing.Size(126, 23);
    	this.materialLabel2.TabIndex = 37;
    	this.materialLabel2.Text = "Criterio de filtro";
    	// 
    	// button_origin
    	// 
    	this.button_origin.AutoSize = true;
    	this.button_origin.Depth = 0;
    	this.button_origin.Icon = null;
    	this.button_origin.Location = new System.Drawing.Point(44, 87);
    	this.button_origin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.button_origin.MouseState = MaterialSkin.MouseState.HOVER;
    	this.button_origin.Name = "button_origin";
    	this.button_origin.Primary = false;
    	this.button_origin.selected = false;
    	this.button_origin.Size = new System.Drawing.Size(117, 36);
    	this.button_origin.TabIndex = 46;
    	this.button_origin.Text = "Según origen";
    	this.button_origin.UseVisualStyleBackColor = true;
    	// 
    	// FormStatsHome
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.ClientSize = new System.Drawing.Size(709, 440);
    	this.Controls.Add(this.button_origin);
    	this.Controls.Add(this.check_dia);
    	this.Controls.Add(this.combo_dia);
    	this.Controls.Add(this.check_mes);
    	this.Controls.Add(this.check_año);
    	this.Controls.Add(this.combo_mes);
    	this.Controls.Add(this.combo_año);
    	this.Controls.Add(this.radio_personalizado);
    	this.Controls.Add(this.radio_historico);
    	this.Controls.Add(this.materialLabel2);
    	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    	this.Name = "FormStatsHome";
    	this.Text = "FormStatsHome";
    	this.Load += new System.EventHandler(this.FormStatsHomeLoad);
    	this.ResumeLayout(false);
    	this.PerformLayout();
    }
    private MaterialSkin.Controls.MaterialFlatButton button_origin;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialRadioButton radio_historico;
    private MaterialSkin.Controls.MaterialRadioButton radio_personalizado;
    private System.Windows.Forms.ComboBox combo_año;
    private System.Windows.Forms.ComboBox combo_mes;
    private MaterialSkin.Controls.MaterialCheckBox check_año;
    private MaterialSkin.Controls.MaterialCheckBox check_mes;
    private System.Windows.Forms.ComboBox combo_dia;
    private MaterialSkin.Controls.MaterialCheckBox check_dia;
  }
}
