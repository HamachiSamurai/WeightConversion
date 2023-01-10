using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightConversion
{
    public partial class Form1 : Form
    {
        private double kg = 1;
        private double lb = 2.2;
        private int ErrorCount;
         
        public Form1()
        {
            InitializeComponent();
        }


        //マッスルマジックボタン押下
        private void ConversionButtonClicked(object sender, EventArgs e)
        {
            double inputKg;
            bool correctValue = Double.TryParse(this.kgTextBox.Text, out inputKg);
            kgTextBox.Enabled = false;
            conversionButton.Enabled = false;



            if (correctValue)
            {
                this.lbTextBox.Text = ConversionKgTolb(inputKg).ToString();
            }
            else
            {
                ErrorMessage();
            }
        }

        // KgをLbに変換
        public double ConversionKgTolb(double inputKg)
        {
            double conversionedValue = inputKg * this.lb;
            return conversionedValue;
        }


        // LbをKgに変換
        public double ConversionLbToKg(double inputLb)
        {
            double conversionedValue =inputLb * this.kg / this.lb;
            return conversionedValue;
        }

        private void ResetButtonClicked(object sender, EventArgs e)
        {
            kgTextBox.Text = null;
            lbTextBox.Text = null;
            kgTextBox.Enabled = true;
            conversionButton.Enabled = true;
            AA.Text =
                "　　　　　　　　彡⌒ ミ\r\n" +
                "　　　　　　　_（´・ω・｀）_　ええから入力してみな\r\n" +
                "　　　γ´⌒´-－ヾｖーヽ⌒ヽ　　　　\r\n" +
                "　　／⌒　 ｨ 　　　｀ｉ´　　）; ｀ヽ\r\n" +
                "　 /　　 　ﾉ＾ ､＿__￥＿_人　　|　　\r\n" +
                "　 　　,,,ノ爻＼_　_人　ﾉｒ;＾ >　 ）\r\n" +
                "　（　　 <_ ＼ﾍ､,, __,+､__ｒﾉ/　　/\r\n" +
                "　　ヽ_　　＼ ）ゝ､__,+､_ｱ〃 ／\r\n" +
                "　　　 ヽ､___ ヽ.　ヽ　　/〈　 ｿ、\r\n" +
                "　　　　 　〈J　.〉;;;;;;;;;;;;;;;;;ヽ-´";

        }

        public void  ErrorMessage()
        {
            ErrorCount += 1;
            AA.Text =
                "不正な値を検出したぞ。\r\n" +
                "どうやらダンベルで捻り潰されたいようだな\r\n"+
                "　 ／ﾌﾌ 　　　　　　 ム｀ヽ\r\n" +
                "　/ ノ)　　ﾍ⌒ヽﾌ　　　）　ヽ\r\n" +
                "ﾞ/ ｜　　（＾Å＾）ノ⌒（ゝ._,ノ\r\n" +
                "/　ﾉ⌒7⌒ヽーく　 ＼　／\r\n" +
                "丶＿ ノ ｡　　 ノ､　　｡|/\r\n" +
                "　　`ヽ `ー-'´_人`ー'ﾉ\r\n" +
                "　　　 丶 ￣ _人'彡ﾉ\r\n" +
                "　　　　ﾉ　　r'十ヽ/\r\n" +
                "　　／｀ヽ_/　十∨､";

            switch(ErrorCount)
            {   
                //警告
                case 3:
                    AA.Text =
                        "　　　　　 ∧＿∧\r\n" +
                        "　　　　　（´･ω･｀）  仏(マッチョ)の顔も3度まで。\r\n" +
                        "　　 　 ／ >‐　、-ヽ          次はもうない。\r\n" +
                        "　　　/丶ﾉ､_。.ﾉ ._｡）.\r\n" +
                        ".　　〈 、〈Y　,ーiｰ〈ト 〉\r\n" +
                        "　　　＼_ξ~~~~~~~Y\r\n" +
                        "　　　　　|＿＿/＿_|\r\n" +
                        "　　　　　 |、,ﾉ | ､_ﾉ\r\n" +
                        "　　　 　 〈　!〉〈ノ/\r\n" +
                        "　　　　　(＿) (＿_)";
                    break;

                // 終了
                case 4:
                    
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    kgTextBox.Visible = false;
                    lbTextBox.Visible = false;
                    conversionButton.Visible = false;
                    resetButton.Visible = false;
                    secretButton.Visible = false;
                    overLabel.Visible = true;
                    


                    AA.Location = new Point(56, 55);
                    AA.Text =
                        "　　　　　　　　　　/⌒丶　　　　 　　　 ／⌒＼\r\n" +
                        "　　　　　　　　　/´ 　　　ヽ 　　 　　 ／、　　　ヽ\r\n" +
                        "　　　　　　　　　| /　　　　|　　　　 /　 /　　　　|\r\n" +
                        "　　　　　.　　 　|　　　　　.|　　　 　|　,/ .　　　　|\r\n" +
                        "　　　　　　　 　|　　 　　　|∧＿∧　/　ﾉ　 　　,|\r\n" +
                        "　　　 　.　　　　|　　　　　|(´・ω・｀)　　　　　 丿    貴様はやりすぎた\r\n" +
                        "　　　　　　　 　ﾉヽ｀ 　　ノヽ　　　/　 ｀　　　/    私の上腕三頭筋を見て平伏すが良い\r\n" +
                        "　　　　　　　 /　　　,/ｿ　　　　　　　　　＼ /\r\n" +
                        "　　　　　　　（　　　　　　　,/　　　 ｀´　　　|　　\r\n" +
                        "　　　　　　　 ＼　　　イ　 ´　 　　　　　　　|　\r\n" +
                        "　　　　　　　　　＼　　ヽ　＼　　　　八　　ﾉ　\r\n" +
                        "　　　　　　　　　　 ヽ　　　　｀　ー ´人｀　/　\r\n" +
                        "　　　　　　　　　　　　＼ 　　　　／ ´,､ヽﾉ　　\r\n" +
                        "　　　　　　　　　　　ノ⌒　　　　/　　 　　 |\r\n" +
                        "　　　　　　　　　　/　　　　　　　　　　　　ﾉ_\r\n" +
                        "　　　　　　　　　　|　ﾉ　　　　　ヽ　　　 丿　＼\r\n" +
                        "　　　　　　 /⌒l　|.　　　　　　　　　　/ 　　　　＼\r\n" +
                        "　　　　 　 /　　l,丿　,　　　　　　　■　　　　 .　　＼\r\n" +
                        "　　　　 　|　　/　　´　　　　　 ／⌒`l　　　　　　　 ＼　\r\n" +
                        "　　　　　丿 /　　　,　　　　 .／　　　ヽ　　　ヽ　　　　|　\r\n" +
                        "　　　　/　　|,　　　|　　 　／　　　　　 ）＼　　　　　　ヽ　\r\n" +
                        "　　　　ヽ　ノ　 　 ヽ__,／　　　　　 .　（　 _＼＿ 　　　　|\r\n" +
                        "　　　 (_)__)|＿＿＿,/　　　　　　　　　 (__)_)_)ヽ、＿＿/";
                    break;
            }
        }
    }
}
