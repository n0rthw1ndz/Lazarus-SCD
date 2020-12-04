using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lazarus_SCD
{
    public static class LIB_EXE
    {

        public static string EXE_PATH;
        public static int COMBO_OFFSET = 828936;


        public static UInt32[] combo_ptrs = new UInt32[35];
        public static IntPtr[] Ptrs = new IntPtr[35];
        
        
        public struct item_entry_data_obj { 
        
        }

        public static UInt32 ReverseBytes(UInt32 value)
        {
            //System.Windows.Forms.MessageBox.Show(value.ToString("X"));
            // move last to first, 2nd st   ays the same
            UInt32 val = (value & 0x0000FF00U) << 16 | (value & 0x00FF0000U) >> 4 | (value & 0x0000000F) << 4;

            byte[] array = BitConverter.GetBytes(val);

           



             //   (value & 0x00F00000U) >> 8
             //| (value & 0x000000F0U) << 4 | (value & 0x00F00000U)  << 12;
            //| (value & 0x000000FFU) << 12;

            //string strval = val.ToString("X");
            //strval = strval.Substring(0, strval.Length - 1);

            //val = UInt32.Parse(strval, System.Globalization.NumberStyles.HexNumber);


            //  System.Windows.Forms.MessageBox.Show(intValue.ToString());

            // System.Windows.Forms.MessageBox.Show(binary.Remove(binary.Length - Place, 1));

            return val;
           


        }

        public static void COMBO_PTR_PARSE(string exePath) {

            if (File.Exists(exePath))
            {

                using (FileStream fs = new FileStream(exePath, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {

                        fs.Seek(COMBO_OFFSET, SeekOrigin.Begin);

                        for (int i = 0; i < combo_ptrs.Length; i++)
                        {
                            combo_ptrs[i] = br.ReadUInt32();
                            //IntPtr ptr = new IntPtr(combo_ptrs[i]);
                               combo_ptrs[i] = ReverseBytes(combo_ptrs[i]);
                            //byte[] array = BitConverter.GetBytes(combo_ptrs[i]);
                            //rray.Reverse(array);
                            //combo_ptrs[i] = BitConverter.ToUInt32(array,0);


                             System.Windows.Forms.MessageBox.Show(combo_ptrs[i].ToString("X") + " " + combo_ptrs[i].ToString());

                           // fs.Seek(combo_ptrs[i], SeekOrigin.Begin);
                           // byte t = br.ReadByte();
                         //   System.Windows.Forms.MessageBox.Show(t.ToString("X"));
                        }





                    }

                }
            }

        }


    }
}
