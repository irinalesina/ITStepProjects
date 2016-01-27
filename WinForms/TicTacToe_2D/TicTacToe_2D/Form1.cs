using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_2D
{
    public partial class FormGame : Form
    {
        TableLayoutPanel tableField;
        List<Button> fieldButtons = new List<Button>();
        public int fieldSize = 3; //hurdcode =)
        public int cellSize = 100; //hurdcode =)
        public FormGame()
        {
            // Create table and fill it with buttons
            tableField = new TableLayoutPanel() { Location = new Point(170, 110),
                ColumnCount = fieldSize, RowCount = fieldSize, BackColor = System.Drawing.Color.YellowGreen,
                CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial, AutoSize = true };

            for(int i = 0; i < fieldSize; i++)
            {
                //tableField.RowStyles.Add(new RowStyle(SizeType.Absolute, cellSize));

                for(int j = 0; j < fieldSize; j++)
                {
                    //tableField.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellSize));

                    tableField.Controls.Add(new Button(){ Width = cellSize, Height = cellSize,
                        BackColor = System.Drawing.Color.LightYellow,
                        TextAlign = ContentAlignment.MiddleCenter},j, i);
                }
            }

            // add table to FornGame
            this.Controls.Add(tableField);

            //tableField.Left = (this.ClientSize.Width - tableField.Width) / 2;
            //tableField.Top = (this.ClientSize.Height - tableField.Height) / 2;

            InitializeComponent();
        }
    }
}
