using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0907_test1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //傳值呼叫
        private void button1_Click(object sender, EventArgs e) {
            int a = 0;
            function1(a);
            MessageBox.Show(a.ToString());
        }

        //傳址呼叫 ref
        private void button2_Click(object sender, EventArgs e) {
            int a = 0;
            function2(ref a);
            MessageBox.Show(a.ToString());
        }

        //傳址呼叫
        private void button3_Click(object sender, EventArgs e) {
            int[] a = {1,2};
            function3(a);
            MessageBox.Show("" + a[0] + "" + a[1]);
        }

        void function1(int a) {
            a += 100;
        }
        void function2(ref int a) {
            a += 200;
        }
        void function3(int[] a) {
            a[0] = 4;
            a[1] = 5;

        }
    }
}
