using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//e-sports 샐러리캡 - 팀 구성
//30달러로 선수 구성
//탭 컨트롤 - 포지션 별로 탭 페이지 5개 
//프로그래스바로 0부터 30까지 증감
//선수들 마다 라디오 버튼, 가격 설정
//선수 선택하고 pick 버튼 누르면 위의 픽처박스에 올라감.
//다음 페이지로 이동 시, 전에 선택했던 선수들도 그대로 존재함.
//선수들 구성이 30달러가 넘을시 메시지 박스가 나오게 됨.


namespace kiosk
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public int topValue = 0;
        public int jugValue = 0;
        public int midValue = 0;
        public int adValue = 0;
        public int supValue = 0;
        public void Form7_Load(object sender, EventArgs e)
        {
            //top,jug,mid,ad,sup의 라디오버튼 체크변경시 프로그래스바 업데이트 
            top10.CheckedChanged += top_CheckedChanged;
            top9.CheckedChanged += top_CheckedChanged;
            top8.CheckedChanged += top_CheckedChanged;
            top7.CheckedChanged += top_CheckedChanged;
            top6.CheckedChanged += top_CheckedChanged;
            top5.CheckedChanged += top_CheckedChanged;
            top4.CheckedChanged += top_CheckedChanged;
            top3.CheckedChanged += top_CheckedChanged;
            top2.CheckedChanged += top_CheckedChanged;
            top1.CheckedChanged += top_CheckedChanged;
            jug10.CheckedChanged += jug_CheckedChanged;
            jug9.CheckedChanged += jug_CheckedChanged;
            jug8.CheckedChanged += jug_CheckedChanged;
            jug7.CheckedChanged += jug_CheckedChanged;
            jug6.CheckedChanged += jug_CheckedChanged;
            jug5.CheckedChanged += jug_CheckedChanged;
            jug4.CheckedChanged += jug_CheckedChanged;
            jug3.CheckedChanged += jug_CheckedChanged;
            jug2.CheckedChanged += jug_CheckedChanged;
            jug1.CheckedChanged += jug_CheckedChanged;
            mid10.CheckedChanged += mid_CheckedChanged;
            mid9.CheckedChanged += mid_CheckedChanged;
            mid8.CheckedChanged += mid_CheckedChanged;
            mid7.CheckedChanged += mid_CheckedChanged;
            mid6.CheckedChanged += mid_CheckedChanged;
            mid5.CheckedChanged += mid_CheckedChanged;
            mid4.CheckedChanged += mid_CheckedChanged;
            mid3.CheckedChanged += mid_CheckedChanged;
            mid2.CheckedChanged += mid_CheckedChanged;
            mid1.CheckedChanged += mid_CheckedChanged;
            ad10.CheckedChanged += ad_CheckedChanged;
            ad9.CheckedChanged += ad_CheckedChanged;
            ad8.CheckedChanged += ad_CheckedChanged;
            ad7.CheckedChanged += ad_CheckedChanged;
            ad6.CheckedChanged += ad_CheckedChanged;
            ad5.CheckedChanged += ad_CheckedChanged;
            ad4.CheckedChanged += ad_CheckedChanged;
            ad3.CheckedChanged += ad_CheckedChanged;
            ad2.CheckedChanged += ad_CheckedChanged;
            ad1.CheckedChanged += ad_CheckedChanged;
            sup10.CheckedChanged += sup_CheckedChanged;
            sup9.CheckedChanged += sup_CheckedChanged;
            sup8.CheckedChanged += sup_CheckedChanged;
            sup7.CheckedChanged += sup_CheckedChanged;
            sup6.CheckedChanged += sup_CheckedChanged;
            sup5.CheckedChanged += sup_CheckedChanged;
            sup4.CheckedChanged += sup_CheckedChanged;
            sup3.CheckedChanged += sup_CheckedChanged;
            sup2.CheckedChanged += sup_CheckedChanged;
            sup1.CheckedChanged += sup_CheckedChanged;

        }
        public void top_CheckedChanged(object sender, EventArgs e)
        {
            //topValue는 위쪽에 초기화 되어있음.
            //선수 선택시 value값이 바뀌게 되고 그 값을 progressBar1에 넣어줌


            if (top10.Checked) topValue = 10;
            else if (top9.Checked) topValue = 9;
            else if (top8.Checked) topValue = 8;
            else if (top7.Checked) topValue = 7;
            else if (top6.Checked) topValue = 6;
            else if (top5.Checked) topValue = 5;
            else if (top4.Checked) topValue = 4;
            else if (top3.Checked) topValue = 3;
            else if (top2.Checked) topValue = 2;
            else if (top1.Checked) topValue = 1;
            else topValue = 0;

        }
        public void btn_select_Click(object sender, EventArgs e)
        {
            //top페이지에서 pick버튼 -> 위쪽의 픽쳐박스에 해당사진이 나오고 선수가격도 설정되게 if문 설정
            if (top10.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.kiin;
                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label1.Text;
            }
            if (top9.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.zeus;

                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label2.Text;
            }
            if (top8.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.doran;

                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label3.Text;
            }
            if (top7.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.kingen;
                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label4.Text;
            }
            if (top6.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.Canna;
                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label5.Text;
            }
            if (top5.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.rascal;
                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label6.Text;
            }
            if (top4.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.dudu;
                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label7.Text;
            }
            if (top3.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.Morgan;
                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label8.Text;
            }
            if (top2.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.dndn;
                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label9.Text;
            }
            if (top1.Checked == true)
            {
                pictureBox_top.Image = Properties.Resources.budol;
                pictureBox_top.SizeMode = PictureBoxSizeMode.StretchImage;
                label62.Text = label10.Text;
            }
                progressBar1.Value = topValue;         
            }
        public void jug_CheckedChanged(object sender, EventArgs e)
        {
            if (jug10.Checked) jugValue = 10;
            else if (jug9.Checked) jugValue = 9;
            else if (jug8.Checked) jugValue = 8;
            else if (jug7.Checked) jugValue = 7;
            else if (jug6.Checked) jugValue = 6;
            else if (jug5.Checked) jugValue = 5;
            else if (jug4.Checked) jugValue = 4;
            else if (jug3.Checked) jugValue = 3;
            else if (jug2.Checked) jugValue = 2;
            else if (jug1.Checked) jugValue = 1;
            else jugValue = 0;

        }
        public void button1_Click(object sender, EventArgs e)
        {
            //jug페이지에서 pick버튼 -> 위쪽의 픽쳐박스에 해당사진이 나오고 선수가격도 설정되게 if문 설정
            if (jug10.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.peanut;
    
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label1.Text;
            }
            if (jug9.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.Canyon;

                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label2.Text;
            }
            if (jug8.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.cuzz;
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label3.Text;
            }
            if (jug7.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.oner;
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label4.Text;
            }
            if (jug6.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.umti;
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label5.Text;
            }
            if (jug5.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.juhan;
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label6.Text;
            }
            if (jug4.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.willer;
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label7.Text;
            }
            if (jug3.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.youngjae;
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label8.Text;
            }
            if (jug2.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.sylvie;
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label9.Text;
            }
            if (jug1.Checked == true)
            {
                pictureBox11.Image = Properties.Resources.Grizzly;
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label68.Text = label10.Text;
            }

            progressBar2.Value = jugValue + topValue;
        }
        public void mid_CheckedChanged(object sender, EventArgs e)
        {
            if (mid10.Checked) midValue = 10;
            else if (mid9.Checked) midValue = 9;
            else if (mid8.Checked) midValue = 8;
            else if (mid7.Checked) midValue = 7;
            else if (mid6.Checked) midValue = 6;
            else if (mid5.Checked) midValue = 5;
            else if (mid4.Checked) midValue = 4;
            else if (mid3.Checked) midValue = 3;
            else if (mid2.Checked) midValue = 2;
            else if (mid1.Checked) midValue = 1;
            else midValue = 0;          
        }
        public void button2_Click(object sender, EventArgs e)
        {
            //mid페이지에서 pick버튼 -> 위쪽의 픽쳐박스에 해당사진이 나오고 선수가격도 설정되게 if문 설정
            if (mid10.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.faker;
                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label36.Text;
            }
            if (mid9.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.chovy;
                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label35.Text;
            }
            if (mid8.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.Zeka;
                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label33.Text;
            }
            if (mid7.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.Bdd;
                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label31.Text;
            }
            if (mid6.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.showmaker;

                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label29.Text;
            }
            if (mid5.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.clozer;

                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label34.Text;
            }
            if (mid4.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.fate;
                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label32.Text;
            }
            if (mid3.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.bulldog;
                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label30.Text;
            }
            if (mid2.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.karis;
                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label28.Text;
            }
            if (mid1.Checked == true)
            {
                pictureBox27.Image = Properties.Resources.quad;
                pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                label74.Text = label27.Text;
            }
                progressBar3.Value = midValue + topValue + jugValue; 
        }
        public void ad_CheckedChanged(object sender, EventArgs e)
        {
            if (ad10.Checked) adValue = 10;
            else if (ad9.Checked) adValue = 9;
            else if (ad8.Checked) adValue = 8;
            else if (ad7.Checked) adValue = 7;
            else if (ad6.Checked) adValue = 6;
            else if (ad5.Checked) adValue = 5;
            else if (ad4.Checked) adValue = 4;
            else if (ad3.Checked) adValue = 3;
            else if (ad2.Checked) adValue = 2;
            else if (ad1.Checked) adValue = 1;
            else adValue = 0;          


        }
        public void button3_Click(object sender, EventArgs e)
        {
            //ad페이지에서 pick버튼 -> 위쪽의 픽쳐박스에 해당사진이 나오고 선수가격도 설정되게 if문 설정

            if (ad10.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.deft;
                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label48.Text;
            }
            if (ad9.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.Viper;
                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label47.Text;
            }
            if (ad8.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.Gumayusi;
                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label45.Text;
            }
            if (ad7.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.Aiming;
                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label43.Text;
            }
            if (ad6.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.peyz;
                    
                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label41.Text;
            }
            if (ad5.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.teddy;

                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label46.Text;
            }
            if (ad4.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.hena;

                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label44.Text;
            }
            if (ad3.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.taeyoon;

                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label42.Text;
            }
            if (ad2.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.jiwoo;

                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label40.Text;
            }
            if (ad1.Checked == true)
            {
                pictureBox41.Image = Properties.Resources.paduck;

                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                label80.Text = label39.Text;
            }
            try
            {
                progressBar4.Value = adValue + topValue + jugValue + midValue;
            }
            catch
            {
                MessageBox.Show("30달러를 넘겼습니다. 다시 선택하시오.");
            }

        }
        public void sup_CheckedChanged(object sender, EventArgs e)
        {
            if (sup10.Checked) supValue = 10;
            else if (sup9.Checked) supValue = 9;
            else if (sup8.Checked) supValue = 8;
            else if (sup7.Checked) supValue = 7;
            else if (sup6.Checked) supValue = 6;
            else if (sup5.Checked) supValue = 5;
            else if (sup4.Checked) supValue = 4;
            else if (sup3.Checked) supValue = 3;
            else if (sup2.Checked) supValue = 2;
            else if (sup1.Checked) supValue = 1;
            else supValue = 0;


        }
        public void button4_Click(object sender, EventArgs e)
        {
            //sup페이지에서 pick버튼 -> 위쪽의 픽쳐박스에 해당사진이 나오고 선수가격도 설정되게 if문 설정

            if (sup10.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.keria;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label60.Text;
            }
            if (sup9.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.Lehends;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label59.Text;
            }
            if (sup8.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.delight;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label57.Text;
            }
            if (sup7.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.beryl;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label55.Text;
            }
            if (sup6.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.Life;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label53.Text;
            }
            if (sup5.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.Kellin;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label58.Text;
            }
            if (sup4.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.effort;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label56.Text;
            }
            if (sup3.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.kael;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label54.Text;

            }
            if (sup2.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.peter;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label52.Text;

            }
            if (sup1.Checked == true)
            {
                pictureBox55.Image = Properties.Resources.jun;

                pictureBox55.SizeMode = PictureBoxSizeMode.StretchImage;
                label86.Text = label51.Text;
            }
            try
            {
                progressBar5.Value = supValue + topValue + jugValue + midValue + adValue;
            }
            catch
            {
                MessageBox.Show("30달러를 넘겼습니다. 다시 선택하시오.");
            }
        }
   
        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //탭 컨트롤 인덱스 변경시, 그 전 선택 했던 선수가 그대로 나오게됨.
            if (tabControl1.SelectedIndex == 0)
            {
                label63.Text = label68.Text; //선수 달러 변경 
                label64.Text = label74.Text; // 인덱스가 무작위로 바뀌어도 선택한 선수에 해당하는 달러값이 나오게됨
                label65.Text = label80.Text;
                label66.Text = label86.Text;

                if (pictureBox11.Image != null)
                    pictureBox_jug.Image = pictureBox11.Image;
                if (pictureBox27.Image != null)
                    pictureBox_mid.Image = pictureBox27.Image;
                if (pictureBox41.Image != null)
                    pictureBox_ad.Image = pictureBox41.Image;
                if (pictureBox55.Image != null)
                    pictureBox_sup.Image = pictureBox55.Image;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                label67.Text = label62.Text;
                label69.Text = label74.Text;
                label70.Text = label80.Text;
                label71.Text = label86.Text;
                if (pictureBox_top != null)
                    picture.Image = pictureBox_top.Image;
                if (pictureBox27 != null)
                    pictureBox13.Image = pictureBox27.Image;
                if (pictureBox41 != null)
                    pictureBox14.Image = pictureBox41.Image;
                if (pictureBox55 != null)
                    pictureBox15.Image = pictureBox55.Image;
            }
            if (tabControl1.SelectedIndex == 2)
            {
                label72.Text = label62.Text;
                label73.Text = label68.Text;
                label75.Text = label80.Text;
                label76.Text = label86.Text;
                if (pictureBox_top != null)
                    pictureBox29.Image = pictureBox_top.Image;
                if (pictureBox11 != null)
                    pictureBox28.Image = pictureBox11.Image;
                if (pictureBox41 != null)
                    pictureBox26.Image = pictureBox41.Image;
                if (pictureBox55 != null)
                    pictureBox25.Image = pictureBox55.Image;
            }
            if (tabControl1.SelectedIndex == 3)
            {
                label77.Text = label62.Text;
                label78.Text = label68.Text;
                label79.Text = label74.Text;
                label81.Text = label86.Text;
                if (pictureBox_top != null)
                    pictureBox44.Image = pictureBox_top.Image;
                if (pictureBox11 != null)
                    pictureBox43.Image = pictureBox11.Image;
                if (pictureBox27 != null)
                    pictureBox42.Image = pictureBox27.Image;
                if (pictureBox55 != null)
                    pictureBox40.Image = pictureBox55.Image;
            }
            if (tabControl1.SelectedIndex == 4)
            {
                label82.Text = label62.Text;
                label83.Text = label68.Text;
                label84.Text = label74.Text;
                label85.Text = label80.Text;
                if (pictureBox_top != null)
                    pictureBox59.Image = pictureBox_top.Image;
                if (pictureBox11 != null)
                    pictureBox58.Image = pictureBox11.Image;
                if (pictureBox27 != null)
                    pictureBox57.Image = pictureBox27.Image;
                if (pictureBox41 != null)
                    pictureBox56.Image = pictureBox41.Image;
            }
        }

        // 인덱스 이동버튼, 프로그래스 바 표시 
        private void button5_Click(object sender, EventArgs e) 
        {
            tabControl1.SelectedIndex = 1;
            progressBar2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            progressBar1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            progressBar3.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            progressBar2.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            progressBar4.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            progressBar3.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            progressBar5.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            progressBar4.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e) // sup 페이지 에서 버튼 클릭시 모달폼으로 이동
        {                                                       // 5명의 선수가 모달폼에 나오게끔 클래스를 생성, 객체 
            ModalFormData formData = new ModalFormData();
            formData.TopImage = pictureBox_top.Image;
            formData.JugImage = pictureBox11.Image;
            formData.MidImage = pictureBox27.Image;
            formData.AdImage = pictureBox41.Image;
            formData.SupImage = pictureBox55.Image;

            using (ModalForm modal = new ModalForm(formData)) 
            {
                modal.ShowDialog();
            }
        }
    }
}
