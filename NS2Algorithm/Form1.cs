using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;


namespace NS2Algorithm
{
    public partial class Form1 : Form
    {
        static readonly char[] alphabets = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int[,] vertex = { { 0, 0 }, { 0, 0 }, { 0, 0 } };
        static int x = 0, y = 1, z = 2;
        static int counter = 0;
        static bool increaseTriangle;

        public Form1()
        {
            InitializeComponent();

            key11.Text = "203";
            key12.Text = "567";
            key21.Text = "765";
            key22.Text = "327";
            key31.Text = "599";
            key32.Text = "423";
        }
        private void runClick(object sender, EventArgs e)
        {
            if(int.TryParse(key11.Text, out int OU) && int.TryParse(key12.Text, out OU) && int.TryParse(key21.Text, out OU) && int.TryParse(key22.Text, out OU) && int.TryParse(key31.Text, out OU) && int.TryParse(key32.Text , out OU))
            {
                warning.Text = null;
                setVertex(int.Parse(key11.Text), int.Parse(key12.Text), int.Parse(key21.Text), int.Parse(key22.Text), int.Parse(key31.Text), int.Parse(key32.Text));
                
                string plainText = inputBox.Text;
                encryptBox.Text = encryptText(plainText);
                string encoded = encryptBox.Text;

                setVertex(int.Parse(key11.Text), int.Parse(key12.Text), int.Parse(key21.Text), int.Parse(key22.Text), int.Parse(key31.Text), int.Parse(key32.Text));
                 
                StringBuilder decoded = new StringBuilder();
                decoded.Append(decryptText(encoded.ToString()));
                decryptBox.Text = decoded.ToString();
            }
            else
            {
                warning.Text = " Try only numerical digits 0-9 ";
            }
        }

        // finds character in the array. Soon to be removed after finding an alternate way 
        public static int findCharacter(char findable)
        {
            for (int i = 0; i < alphabets.Length; i++)
            {
                if (alphabets[i] == findable)
                    return i;
            }
            return -1;
        }

        // encryption magic happens here !!!
        public static string encryptText(string message)
        {
            int key = 0;
            StringBuilder enc = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                key = calculateCenter();
                enc.Append((char)((int)message[i] + key));
            }

            return enc.ToString();
        }
        //decryption sorcery happen here !!!
        public static string decryptText(string message)
        {
            int key = 0;
            StringBuilder dec = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                key = calculateCenter();
                dec.Append((char)((int)message[i] - key));
            }

            return dec.ToString();
        }

        //vertex is predefined here. 
        public static void setVertex(int var1, int var2, int var3, int var4, int var5, int var6)
        {
            int[] publicKey = { var1 , var2 };
            int[] privateKey1 = { var3 , var4 };
            int[] privateKey2 = { var5 , var6 };
            increaseTriangle = false;
            counter = 0;

            vertex[0, 0] = publicKey[0];
            vertex[0, 1] = publicKey[1];
            vertex[1, 0] = privateKey1[0];
            vertex[1, 1] = privateKey1[1];
            vertex[2, 0] = privateKey2[0];
            vertex[2, 1] = privateKey2[1];
        }

        // this function finds new vertex coordinates using the existing vertex coordinates as midpoints of sides of the triangle.
        public static void midpointsFromVertex()
        {
            int[] currentX = { 0, 0 }, currentY = { 0, 0 }, currentZ = { 0, 0 };

            for (int i = 0; i < 2; i++)
            {
                currentX[i] = (vertex[0, i] + vertex[1, i]) / 2;
                currentY[i] = (vertex[1, i] + vertex[2, i]) / 2;
                currentZ[i] = (vertex[2, 0] + vertex[0, i]) / 2;
            }
            vertex[0, 0] = currentX[0];
            vertex[0, 1] = currentX[1];
            vertex[1, 0] = currentY[0];
            vertex[1, 1] = currentY[1];
            vertex[2, 0] = currentZ[0];
            vertex[2, 0] = currentZ[1];
        }

        // clears all the keys in GUI when user clicks "Clear keys" button.
        private void ClearKeys(object sender, EventArgs e)
        {
            key11.Text = "";
            key12.Text = "";
            key21.Text = "";
            key22.Text = "";
            key31.Text = "";
            key32.Text = "";
            decryptBox.Text = "";
            encryptBox.Text = "";
        }

        // this function finds new vertex coordinates using the midpoints of sides of the triangle by existing vertex coordinates.
        public static void vertexFromMidpoints()
        {
            int[] currentX = { 0, 0 }, currentY = { 0, 0 }, currentZ = { 0, 0 };

            for (int i = 0; i < 2; i++)
            {
                currentX[i] = vertex[x, i] + vertex[y, i] - vertex[z, i];
                currentY[i] = vertex[x, i] - vertex[y, i] + vertex[z, i];
                currentZ[i] = vertex[y, i] - vertex[z, i] + vertex[x, i];
            }
            vertex[0, 0] = currentX[0];
            vertex[0, 1] = currentX[1];
            vertex[1, 0] = currentY[0];
            vertex[1, 1] = currentY[1];
            vertex[2, 0] = currentZ[0];
            vertex[2, 0] = currentZ[1];
        }

        // This calculates the centroid of the triangle and also maintains the growth and shrink of the triangle
        public static int calculateCenter()
        {
            int[] centroid = { 0, 0 };
            if (counter % 5 == 0)
            {
                increaseTriangle = !increaseTriangle;
                counter = 0;
            }
            counter++;

            if (increaseTriangle)
                midpointsFromVertex();
            else
                vertexFromMidpoints();

            centroid[0] = (vertex[0, 0] + vertex[1, 0] + vertex[2, 0]) / 3;
            centroid[1] = (vertex[0, 1] + vertex[1, 1] + vertex[2, 1]) / 3;
            int center = centroid[0] + centroid[1];
            Console.WriteLine(center);
            return center;
        }
    }
}