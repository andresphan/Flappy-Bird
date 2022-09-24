namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x_top1, y_top1,x_bottom1, y_bottom1;
        int x_chim, y_chim;
        int kc = 300;

       

        int x_top2, y_top2,x_bottom2, y_bottom2;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                y_chim -= 50;
                


            }



        }

        int dem = 0;
        private void btn_Click(object sender, EventArgs e)
        {
           dem++;

            if (dem % 2 != 0) { timer.Start(); }
     
            
            


        }

        int cap1, cap2;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.Left = 0;
            this.Top = 0;

            this.Bounds = Screen.PrimaryScreen.Bounds;


            cap1 =this.Width+ 300;
            top1.Size = new Size(270, 1000);
            
            cap2 = 500 + 400 + top1.Width;
            y_top1 = -500;
            top1.Location=new Point(cap1, y_top1);







            bottom1.Size = new Size(270, 1000);
           
            y_bottom1 =(1000+y_top1)+kc;
            bottom1.Location = new Point(cap1, y_bottom1);





           
            y_top2 = -500;
            top2.Location = new Point(cap2, y_top2);
           
            y_bottom2 = kc + (1000 + y_top2);
           bottom2.Location=new Point(cap2, y_bottom2);

            conchim.Size = new Size(127, 100);

            x_chim = conchim.Location.X;
            y_chim = conchim.Location.Y; 
            timer.Interval = 10;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {

            cap1 -= 8;
            cap2 -= 8;
           

            
            //y_top1 = -500;
            top1.Location = new Point(cap1, y_top1);







           // bottom1.Size = new Size(270, 1000);

           // y_bottom1 = (1000 + y_top1) + kc;
            bottom1.Location = new Point(cap1, y_bottom1);






            y_top2 = -500;
            top2.Location = new Point(cap2, y_top2);

           y_bottom2 = kc + (1000 + y_top2);
            bottom2.Location = new Point(cap2, y_bottom2);

          //  conchim.Size = new Size(127, 100);
            if(cap1+top1.Width<=0)
            {
               
                Random rd=new Random();
                y_top1 = rd.Next(-800, -400);
                y_bottom1 = (1000 + y_top1) + kc;
                cap1 = cap2 + top1.Width + 400;
                top1.Location = new Point(cap1, y_top1);
                bottom1.Location = new Point(cap1, y_bottom1);
            }
            if(cap2+top2.Width<=0)
            {
                Random rd = new Random();
                y_top2 = rd.Next(-800, -400);
                cap2 = cap1 + top1.Width + 400+500;
                y_bottom1 = (1000 + y_top2) + kc;
                top2.Location = new Point(cap2, y_top2);
                bottom2.Location=new Point(cap2, y_bottom2);


            }
            
            if(conchim.Location.Y+conchim.Height<=this.Height)
            {

                y_chim += 2;
                conchim.Location = new Point(x_chim, y_chim);



            }else
            {
                y_chim += 100;
                conchim.Location = new Point(x_chim, y_chim);
                timer.Stop();
                DialogResult rs = MessageBox.Show("ban co muon tiep tuc choi", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rs == DialogResult.Yes)
                {
                    timer.Start();
                    y_chim += 1000;
                    conchim.Location = new Point(x_chim, y_chim);

                }
                else
                {
                    this.Close();
                }
            }
            



        }
    }
}