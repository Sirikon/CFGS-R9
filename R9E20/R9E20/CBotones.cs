using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace R9E20
{
    class CBotones
    {
        const Int32 MARGIN_TOP = 49;
        const Int32 MAX_WIDTH_HEIGHT = 20;
        const Int32 MIN_WIDTH_HEIGHT = 0;
        const Int32 BUTTON_WIDTH = 50;
        const Int32 BUTTON_HEIGHT = 25;
        private Int32 _width;
        private Int32 _height;
        private Form _parent;
        public Button[,] matrix;
        public Int32 totalWidth = 0;
        public Int32 totalHeight = 0;

        public CBotones(Form parent, Int32 width, Int32 height)
        {
            if (width > MAX_WIDTH_HEIGHT)
                _width = MAX_WIDTH_HEIGHT;
            else if (width < MIN_WIDTH_HEIGHT)
                _width = MIN_WIDTH_HEIGHT;
            else
                _width = width;

            if (height > MAX_WIDTH_HEIGHT)
                _height = MAX_WIDTH_HEIGHT;
            else if (height < MIN_WIDTH_HEIGHT)
                _height = MIN_WIDTH_HEIGHT;
            else
                _height = height;

            this._parent = parent;

            GenerateMatrix();
        }

        private void GenerateMatrix ()
        {
            this.matrix = new Button[_width,_height];
            for(int x = 0; x < _width; x++)
            {
                for(int y = 0; y < _height; y++)
                {
                    this.matrix[x, y] = GenerateButton(new Point(BUTTON_WIDTH * x, MARGIN_TOP+(BUTTON_HEIGHT * y)), x, y);
                    this._parent.Controls.Add(this.matrix[x, y]);
                }
            }

            if(this.matrix.Length > 0)
            {
                this.totalWidth = BUTTON_WIDTH * _width;
                this.totalHeight = MARGIN_TOP + (BUTTON_HEIGHT * _height);
            }
        }

        public void destroy()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    this.matrix[x, y].Dispose();
                }
            }
        }

        private Button GenerateButton (Point position, Int32 x, Int32 y)
        {
            Button button = new Button();
            button.Location = position;
            button.Name = "Button_"+x+"_" + y;
            button.Size = new Size(BUTTON_WIDTH, BUTTON_HEIGHT);
            button.TabIndex = 0;
            button.Text = "[" + x + "," + y + "]";
            button.UseVisualStyleBackColor = true;
            button.MouseEnter += new System.EventHandler(ButtonEnter);
            button.MouseLeave += new System.EventHandler(ButtonLeave);
            button.Click += new System.EventHandler(ButtonClick);

            return button;
        }

        private void ButtonEnter (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Cyan;
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.SystemColors.Control;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            MessageBox.Show("Este botón se llama '" + button.Name + "'", "Hiciste Click en un botón");
        }
    }
}
