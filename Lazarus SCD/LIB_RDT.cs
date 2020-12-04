using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lazarus_SCD

{
    public static class LIB_RDT
    {

        public static ListBox LB_OFF { get; set; }
        public static ListView LV_CODE;
        public static ListView LV_BYTE;
        public static System.Windows.Forms.ToolStripLabel LBL_SIZE;

       


        public static int g_TAB = 0;
        public struct RDT_HEADER_OBJ {

           public int[] OBJ_OFFSETS;

        
        }


        public struct SCD_DATA_OBJ {
            public int sub_count;
            public int main_sz;
            public int sub_sz;
            public Int16 short_skip;
            public int[] sub_scd_offs_r; // relative to the scd block
            public int[] sub_scd_offs_t; // rdt relative total
        
        }


        public static int SET_SCD_CMD_LEN(byte xBYTE)
        {

            string xFF = xBYTE.ToString("X").PadLeft(2, '0');   //CONVERT TO HEX BYTE, USE PADDING!

            int cmd_len = 0;

            if (xFF == "00") { cmd_len = 2; }
            if (xFF == "01") { cmd_len = 2; }
            if (xFF == "02") { cmd_len = 2; }   
            if (xFF == "03") { cmd_len = 2; }
            if (xFF == "04") { cmd_len = 4; }   
            if (xFF == "05") { cmd_len = 4; }
            if (xFF == "06") { cmd_len = 4; }
            if (xFF == "07") { cmd_len = 6; }
            if (xFF == "08") { cmd_len = 4; }
            if (xFF == "09") { cmd_len = 2; }
            if (xFF == "0A") { cmd_len = 2; }
            if (xFF == "0B") { cmd_len = 4; }
            if (xFF == "0C") { cmd_len = 26; }
            if (xFF == "0D") { cmd_len = 18; }
            if (xFF == "0E") { cmd_len = 2; }
            if (xFF == "0F") { cmd_len = 8; }

            if (xFF == "10") { cmd_len = 2; }
            if (xFF == "11") { cmd_len = 2; }
            if (xFF == "12") { cmd_len = 10; }
            if (xFF == "13") { cmd_len = 4; }
            if (xFF == "14") { cmd_len = 4; }
            if (xFF == "15") { cmd_len = 2; }
            if (xFF == "16") { cmd_len = 2; }
            if (xFF == "17") { cmd_len = 10; }
            if (xFF == "18") { cmd_len = 26; }
            if (xFF == "19") { cmd_len = 4; }
            if (xFF == "1A") { cmd_len = 2; }
            if (xFF == "1B") { cmd_len = 22; }
            if (xFF == "1C") { cmd_len = 6; }
            if (xFF == "1D") { cmd_len = 2; }
            if (xFF == "1E") { cmd_len = 4; }
            if (xFF == "1F") { cmd_len = 28; }

            if (xFF == "20") { cmd_len = 14; }
            if (xFF == "21") { cmd_len = 14; }
            if (xFF == "22") { cmd_len = 4; }
            if (xFF == "23") { cmd_len = 2; }
            if (xFF == "24") { cmd_len = 4; }
            if (xFF == "25") { cmd_len = 4; }   //WAS 3 BEFORE...
            //if (xFF == "26") { cmd_len = 6; }
            if (xFF == "27") { cmd_len = 2; }
            if (xFF == "28") { cmd_len = 4; }
            if (xFF == "29") { cmd_len = 2; }
            if (xFF == "2A") { cmd_len = 12; }
            if (xFF == "2B") { cmd_len = 4; }
            if (xFF == "2C") { cmd_len = 2; }
            if (xFF == "2D") { cmd_len = 4; }
            //  if (xFF == "2E") { cmd_len = 4; }	//SET BACK TO 4 AGAIN!! NOT SURE IF 3 OR 4 :S
            if (xFF == "2F") { cmd_len = 4; }

            if (xFF == "30") { cmd_len = 12; }
            if (xFF == "31") { cmd_len = 4; }
            if (xFF == "32") { cmd_len = 4; }
            if (xFF == "33") { cmd_len = 4; }
            if (xFF == "34") { cmd_len = 8; }
            if (xFF == "35") { cmd_len = 4; }   //WAS 3 BEFORE...
            if (xFF == "36") { cmd_len = 4; }
            if (xFF == "37") { cmd_len = 4; }
            if (xFF == "38") { cmd_len = 4; }
            if (xFF == "39") { cmd_len = 2; }
            if (xFF == "3A") { cmd_len = 4; }
            if (xFF == "3B") { cmd_len = 6; }
            if (xFF == "3C") { cmd_len = 6; }
            if (xFF == "3D") { cmd_len = 12; }	//MOST PROBABLY 4...    //WAS 3 BEFORE...
            if (xFF == "3E") { cmd_len = 2; }
            if (xFF == "3F") { cmd_len = 6; }

            if (xFF == "40") { cmd_len = 16; }
            if (xFF == "41") { cmd_len = 4; }
            if (xFF == "42") { cmd_len = 4; }
            if (xFF == "43") { cmd_len = 4; }
            if (xFF == "44") { cmd_len = 2; }
            if (xFF == "45") { cmd_len = 44; }
            if (xFF == "46") { cmd_len = 14; }
            if (xFF == "47") { cmd_len = 2; }
            if (xFF == "48") { cmd_len = 2; }
            if (xFF == "49") { cmd_len = 8; }
            if (xFF == "4A") { cmd_len = 2; }
            if (xFF == "4B") { cmd_len = 2; }
            if (xFF == "4C") { cmd_len = 4; }
            if (xFF == "4D") { cmd_len = 2; }
            if (xFF == "4E") { cmd_len = 4; }
            if (xFF == "4F") { cmd_len = 2; }

            if (xFF == "50") { cmd_len = 2; }

            if (xFF == "FC") { cmd_len = 2; }
            if (xFF == "FE") { cmd_len = 2; }
            if (xFF == "FF") { cmd_len = 2; }



            return cmd_len;

        }


        public static void COLOR_BYTE_LEN(int xlength, int index, byte[] barr)
        {

            Color x2 = Color.Black;
            Color x4 = Color.DarkCyan;
            Color x6 = Color.DeepSkyBlue;
            Color x8 = Color.Cyan;
            Color x10 = Color.CornflowerBlue;
            Color x12 = Color.IndianRed;
            Color x14 = Color.Goldenrod;
            Color x16 = Color.Green;
            Color x18 = Color.LightGreen;
            Color x22 = Color.Yellow;
            Color x24 = Color.LightGreen;
            Color x26 = Color.LightPink;

            Color new_color = Color.Black;

            if (xlength == 2) { new_color = x2; }
            if (xlength == 4) { new_color = x4; }
            if (xlength == 6) { new_color = x6; }
            if (xlength == 8) { new_color = x8; }
            if (xlength == 12) { new_color = x12; }
            if (xlength == 14) { new_color = x14; }
            if (xlength == 16) { new_color = x16; }
            if (xlength == 18) { new_color = x18; }
            if (xlength == 20) { new_color = x22; }
            if (xlength == 22) { new_color = x24; }
            if (xlength == 24) { new_color = x26; }


           
            LV_BYTE.Items[index].SubItems.Add(barr.Length.ToString());
            LV_BYTE.Items[index].SubItems[1].ForeColor = new_color;



        }

        //COLOR THE CODE!
        public static void COLOR_CMD(byte XBYTE, int IDX)
        {
            Color new_color = FRM_MAIN.DefaultBackColor;
            Color cmd_flag_op = Color.DarkCyan;
            Color cmd_key = Color.DeepSkyBlue;
            Color cmd_condition = Color.Cyan;
            Color cmd_aot = Color.CornflowerBlue;
            Color cmd_enemy = Color.IndianRed;
            Color cmd_event = Color.Goldenrod;
            Color cmd_obj_model = Color.Green;
            Color cmd_item_set = Color.LightGreen;
            Color cmd_effect_color = Color.Yellow;
            Color cmd_item_aot = Color.LightGreen;

            string xFF = XBYTE.ToString("X").PadLeft(2, '0');

            //CONDITIONS
            if (xFF == "01") { new_color = cmd_event; }     //EVENT END
            if (xFF == "02") { new_color = cmd_event; }     //EVENT NEXT
            if (xFF == "03") { new_color = cmd_event; }
            if (xFF == "04") { new_color = cmd_event; }

            if (xFF == "06") { new_color = cmd_key; }     //IF
            if (xFF == "07") { new_color = cmd_key; }     //ELSE
            if (xFF == "08") { new_color = cmd_key; }     //END IF

            if (xFF == "09") { new_color = cmd_key; }     //SLEEP
            if (xFF == "0A") { new_color = cmd_key; }     //SLEEPING
            if (xFF == "0B") { new_color = cmd_key; }     //WSLEEP
            if (xFF == "0C") { new_color = cmd_key; }     //WSLEEPING 2

            if (xFF == "0D") { new_color = cmd_key; }     //FOR
            if (xFF == "0E") { new_color = cmd_key; }     //NEXT
            if (xFF == "0F") { new_color = cmd_key; }     //WHILE
            if (xFF == "10") { new_color = cmd_key; }     //END WHILE
            if (xFF == "11") { new_color = cmd_key; }     //DO
            if (xFF == "12") { new_color = cmd_key; }     //END DO
            if (xFF == "13") { new_color = cmd_key; }     //SWITCH
            if (xFF == "14") { new_color = cmd_key; }     //CASE
            if (xFF == "15") { new_color = cmd_key; }     //DEFAULT CASE
            if (xFF == "16") { new_color = cmd_key; }     //END SWITCH

            if (xFF == "17") { new_color = cmd_key; }     //GOTO
            if (xFF == "18") { new_color = cmd_key; }     //GO SUB
            if (xFF == "19") { new_color = cmd_key; }     //RETURN

            if (xFF == "1A") { new_color = cmd_key; }     //BREAK
            if (xFF == "1B") { new_color = cmd_key; }     //FOR v2
            if (xFF == "1C") { new_color = cmd_key; }     //BREAK POINT

            if (xFF == "21") { new_color = cmd_condition; }     //CHECK FLAG
            if (xFF == "22") { new_color = cmd_flag_op; }     //SET FLAG
            if (xFF == "23") { new_color = cmd_condition; }     //COMPARE FLAG
            if (xFF == "24") { new_color = cmd_flag_op; }     //COMPARE FLAG
            if (xFF == "25") { new_color = cmd_flag_op; }     //COMPARE FLAG
            if (xFF == "26") { new_color = cmd_flag_op; }     //COMPARE FLAG
            if (xFF == "27") { new_color = cmd_flag_op; }     //COMPARE FLAG

            if (xFF == "2C") { new_color = cmd_aot; }     //SET AOT
            if (xFF == "2D") { new_color = cmd_obj_model; }
            if (xFF == "3B" || xFF == "61") { new_color = cmd_aot; }     //SET DOOR AOT
            if (xFF == "44" | xFF == "7D") { new_color = cmd_enemy; }     //SET ENEMY
            if (xFF == "46") { new_color = cmd_aot; }     //RESET AOT
            if (xFF == "4E") { new_color = cmd_item_aot; }     //SET ITEM AOT

            if (xFF == "67") { new_color = Color.LawnGreen; }
            if (xFF == "72" || xFF == "70" || xFF == "74") { new_color = cmd_effect_color; }

            LV_CODE.Items[IDX].SubItems[1].ForeColor = new_color;

        }

        //NEST THE CODE!
        public static void NEST_CODE(byte XBYTE)
        {
        string g_TAB_STR = "";  //STRING USED TO REPRESENT CODE NESTING
        string FF = XBYTE.ToString("X").PadLeft(2, '0');

            if (FF == "00" && g_TAB > 0) { g_TAB -= 1; } //ESCAPE ELSE..

            if (FF == "03") { g_TAB -= 1; }   //ELSE
            if (FF == "04") { g_TAB -= 1; }   //END IF

            //if (FF == "0E") { g_TAB -= 1; }
            //if (FF == "10") { g_TAB -= 1; }
            //if (FF == "12") { g_TAB -= 1; }
            //if (FF == "16") { g_TAB -= 1; }
            //if (FF == "1A") { g_TAB -= 1; }

            if (g_TAB < 0) { g_TAB = 0; }

            //if (g_TAB < 0) {g_TAB_STR = "";}
            if (g_TAB == 0) { g_TAB_STR = ""; }
            if (g_TAB == 1) { g_TAB_STR = "    "; }
            if (g_TAB == 2) { g_TAB_STR = "    " + "    "; }
            if (g_TAB == 3) { g_TAB_STR = "    " + "    " + "    "; }
            if (g_TAB == 4) { g_TAB_STR = "    " + "    " + "    " + "    "; }
            if (g_TAB == 5) { g_TAB_STR = "    " + "    " + "    " + "    " + "    "; }

            if (FF == "07") { g_TAB += 1; }       //ELSE
            if (FF == "06") { g_TAB += 1; }     //IF
            if (FF == "0D") { g_TAB += 1; }       //
            if (FF == "0F") { g_TAB += 1; }       //
            if (FF == "11") { g_TAB += 1; }       //
            if (FF == "13") { g_TAB += 1; }     //
            //if (FF == "14") { g_TAB += 1; }   //
        }




        public static string BIO_FLAG_COMMENT(string bcode)
        {
            string comment = "";
            byte ARRAY = Convert.ToByte(bcode.Substring(2, 2), 16);
            byte FLAG = Convert.ToByte(bcode.Substring(4, 2), 16);
            byte VALUE = Convert.ToByte(bcode.Substring(6, 2), 16);

            if (ARRAY == 0)
            {
                //if (FLAG == 25 && VALUE == 0) { comment = "GAME DIFFICULTY IS 'EASY'"; }
                //if (FLAG == 25 && VALUE == 1) { comment = "GAME DIFFICULTY IS 'NORMAL'"; }

            }

            if (ARRAY == 5)
            {
                //if (FLAG == 0 && VALUE == 0) { comment = "PLAYER 'LEON'"; }
                //if (FLAG == 0 && VALUE == 1) { comment = "PLAYER 'CLAIRE'"; }

                //if (FLAG == 1 && VALUE == 0) { comment = "SCENARIO A"; }
                //if (FLAG == 1 && VALUE == 1) { comment = "SCENARIO B"; }

                //if (FLAG == 6 && VALUE == 0) { comment = "GAME TYPE IS 'LEON/CLAIRE'"; }
                //if (FLAG == 6 && VALUE == 1) { comment = "GAME TYPE IS 'HUNK/TOFU'"; }

                if (FLAG == 05 && VALUE == 0) { comment = "END LETTERBOX ========================================================================================= "; }
                if (FLAG == 05 && VALUE == 1) { comment = "SHOW LETTERBOX ======================================================================================== "; }

            }
          
            return comment;
        }




        public static void PARSE_RDT_HEADER(string fp, RDT_HEADER_OBJ rdt_obj, FRM_DEBUG debugform, SCD_DATA_OBJ scdobj) {



            //prevent dupes n shit
            debugform.LV_DEBUG.Items.Clear();
            debugform.DEBUG_LOG.Clear();
            LB_OFF.Items.Clear();


            List<int> sub_ptr_list = new List<int>();


            // resize array to hold 19 objects
            Array.Resize(ref rdt_obj.OBJ_OFFSETS, 19);

            using (FileStream fs = new FileStream(fp, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs)) 
                {
                    // seek to object pointers
                    fs.Seek(0x48, SeekOrigin.Begin);

                    for (int i = 0; i < rdt_obj.OBJ_OFFSETS.Length; i++) {

                        // read main header offsets
                        rdt_obj.OBJ_OFFSETS[i] = br.ReadInt32();

                        // dump output to debug listview
                        debugform.LV_DEBUG.Items.Add(i.ToString());
                        debugform.LV_DEBUG.Items[i].SubItems.Add(rdt_obj.OBJ_OFFSETS[i].ToString());
                        debugform.LV_DEBUG.Items[i].SubItems.Add(OFFSET_LUT[i]);


                        // dump do debug log...
                     //   debugform.DEBUG_LOG.AppendText(i.ToString() + "\n");
                        debugform.DEBUG_LOG.AppendText(rdt_obj.OBJ_OFFSETS[i].ToString() + "\n");
                        debugform.DEBUG_LOG.AppendText(OFFSET_LUT[i] + "\n");
                        

                    }


                    // calculate scd info
                    scdobj.main_sz = rdt_obj.OBJ_OFFSETS[7] - rdt_obj.OBJ_OFFSETS[6];
                    LB_OFF.Items.Add("MAIN00.SCD");
                    scdobj.sub_sz = rdt_obj.OBJ_OFFSETS[8] - rdt_obj.OBJ_OFFSETS[7];


                    fs.Seek(rdt_obj.OBJ_OFFSETS[7], SeekOrigin.Begin);

                    scdobj.short_skip = br.ReadInt16();

                   if (scdobj.short_skip == 102) { scdobj.short_skip = 100; }

                    int sub_off = rdt_obj.OBJ_OFFSETS[7] + scdobj.short_skip + 4; // skip the first 00 offset


                 //   MessageBox.Show(sub_off.ToString());
                    // seek to sub offset ptrs
                    fs.Seek(sub_off, SeekOrigin.Begin);

                   

                    // calculate # of sub scds
                    for (int i = 0; i < 25; i++) {

                        int val = br.ReadInt32();

                        if (val != 0x00) {
                            sub_ptr_list.Add(val);
                        }

                        // break out on 0
                        if (val == 0x00) {
                            scdobj.sub_count = i;
                         //   System.Windows.Forms.MessageBox.Show(scdobj.sub_count.ToString());
                            break;
                        }
                    
                    }



                    // re size arrays to hold sub ptrs , reg/ rdt relative
                  //  Array.Resize(ref scdobj.sub_scd_offs_r, scdobj.sub_count);
                    Array.Resize(ref scdobj.sub_scd_offs_t, scdobj.sub_count);


           

                    // recalculate rdt releative sub offs
                    for (int i = 0; i < scdobj.sub_count; i++) {

                        scdobj.sub_scd_offs_t[i] = sub_off + sub_ptr_list[i];
                        LB_OFF.Items.Add("SUB" + i.ToString() + ".SCD");
                        
                      //  System.Windows.Forms.MessageBox.Show(scdobj.sub_scd_offs_t[i].ToString());
                    }


                    FRM_MAIN.SCD_DATA.sub_scd_offs_t = scdobj.sub_scd_offs_t;
                    FRM_MAIN.RDT_HEADER.OBJ_OFFSETS = rdt_obj.OBJ_OFFSETS;

                }


            }

        }



        // <summary>
        // Parse SCD Data via RDT or SCD directly.., if RDT directly.. it only parses the main script, and calculates the length of all the others to run dissasembly
        // </summary>
        // <param name = "sfile" > The filestream</param>
        // <param name = "flag_relative" > format flag, 0 RDT, 1 SCD relative</param>
        public static void BIO_PARSE_SCD_INDEX(string sfile, RDT_HEADER_OBJ rdtobj, int lb_index, SCD_DATA_OBJ scdobj)
        {

               string g_TAB_STR = "";  //STRING USED TO REPRESENT CODE NESTING

            try
            {
                LV_CODE.Items.Clear(); // prevent dupes niggas
                LV_BYTE.Items.Clear();

                FileStream fs = new FileStream(sfile, FileMode.Open); // opening fle streams
                BinaryReader br = new BinaryReader(fs);

                byte bbuffer;
                byte[] barr = new byte[0];
                string bytestr;
                string[] cmd_names;
                int cmd_len = 0;

                 int t_scd_size = 0;
                int lastSubSize = 0;

                bool MAIN = false;

                cmd_names = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\LIB\BIO_SCD_OP_NAMES_O.LIB"); // wow

                // if selected lb index is < the offset array

                // calculate the size of the current selected scd 

               int sel_idx = LB_OFF.SelectedIndices[0];
                int lbcount = LB_OFF.Items.Count - 1;
                //   MessageBox.Show(sel_idx.ToString() + ":" + lbcount);


                int[] sorted_rdt_offsets = rdtobj.OBJ_OFFSETS;
                Array.Sort(sorted_rdt_offsets);

                

                //get index of sub scd.. from the sorted array


                // parse main scd
                if (sel_idx == 0)
                {
                    t_scd_size = rdtobj.OBJ_OFFSETS[7] - rdtobj.OBJ_OFFSETS[6];
                    LBL_SIZE.Text = t_scd_size.ToString();
                    MAIN = true;

                    fs.Seek(rdtobj.OBJ_OFFSETS[6], SeekOrigin.Begin);


                    // parse main
                }
                else // parse sub
                {

                    MAIN = false;
                  
                    if (sel_idx != lbcount)
                    {
                        t_scd_size = scdobj.sub_scd_offs_t[lb_index + 1] - scdobj.sub_scd_offs_t[lb_index];
                        LBL_SIZE.Text = t_scd_size.ToString();
                        //   MessageBox.Show(t_scd_size.ToString());

               

                    }
                    else if (sel_idx == lbcount)
                    {

                        // find the index of the closest rdt header object offset to the last sub scd offset
                        int subscdIDX = Array.BinarySearch(sorted_rdt_offsets, scdobj.sub_scd_offs_t[LB_OFF.Items.Count - 2]);

                        // flip the bits
                        subscdIDX = ~subscdIDX;

                        //  MessageBox.Show(scdobj.sub_scd_offs_t[LB_OFF.Items.Count - 2].ToString());

                        // calculate the last sub size between the last sub scd offset and the next closest rdt offset
                        lastSubSize = sorted_rdt_offsets[subscdIDX] - scdobj.sub_scd_offs_t[LB_OFF.Items.Count - 2];

                        // set offset size
                        t_scd_size = lastSubSize;

                        LBL_SIZE.Text = t_scd_size.ToString();

                        fs.Seek(scdobj.sub_scd_offs_t[lb_index], SeekOrigin.Begin);
                    }

                    // seek to the selected 
                  
                }


                    // this simply parses main scd..(used to), this should be for parsing all scds..?
                    for (int i = 0; i < t_scd_size; i++)
                    {
                        // MessageBox.Show("fs" + fs.Position + SCD_DATA.SCDMAIN_SZ.ToString());

                        //  MessageBox.Show(t_scd_size.ToString());
                        // if (fs.Position >= SCD_DATA.O_SCD_SUB) { break; } // break if we hit sub scd offset

                        LV_CODE.Items.Add(fs.Position.ToString());   // add index to lst side
                        LV_BYTE.Items.Add(fs.Position.ToString()); // add offset to byte code lst
                        LV_CODE.Items[i].UseItemStyleForSubItems = false; // no idea
                        LV_CODE.Items[i].ForeColor = Color.Green;
                        bbuffer = br.ReadByte(); // read entire file into buffer



                        fs.Seek(-1, SeekOrigin.Current);


                        //    if ((bbuffer) == 0) { MessageBox.Show("OPCODE ERROR !!!: " + " " + bbuffer.ToString("X").PadLeft(2, '0') + " OFFSET: " + fs.Position.ToString()); }

                        cmd_len = SET_SCD_CMD_LEN(bbuffer); // set cmd length to currently read opcode length?
                        if (cmd_len == 0) { cmd_len = 1; } // force cmd length to 1?

                        Array.Resize(ref barr, cmd_len); // rsize byte array to cmd length
                        barr = br.ReadBytes(barr.Length); // read the opcode in its entirity

                        bytestr = "";



                        for (int j = 0; j < barr.Length; j++) // loop through currently read buffer and set bytestr to opcode, padding to display without 0?
                        {
                            bytestr += barr[j].ToString("X").PadLeft(2, '0');


                        }


                        NEST_CODE(bbuffer); // not sure yet

                        LV_BYTE.Items[i].SubItems.Add(bytestr);  // add byte string to byte code column


                        //   MessageBox.Show(bbuffer.ToString());
                        if (bbuffer < cmd_names.Length) { LV_CODE.Items[i].SubItems.Add(cmd_names[bbuffer]); }
                    //BIO2_GET_ATTR(i));; // add some index, the cmd name, and its attirubutes to int column

                    /// add byte size to size column

                    COLOR_BYTE_LEN(barr.Length, i,barr);
                   // LV_BYTE.Items[i].SubItems.Add(barr.Length.ToString());
                  //
                       LV_CODE.Items[i].SubItems.Add(""); // comment?
                      



                    COLOR_CMD(bbuffer, i); // color code the interrepted shit
                   




                    //     LV_CODE.Items[i].SubItems[2].ForeColor = Color.Cyan; // force comments green
                    // LV_CODE.Items[i].SubItems[2].Text = BIO_FLAG_COMMENT(LV_BYTE.Items[i].SubItems[1].Text);
                    //    if (bbuffer == 4) { LV_CODE.Items[i].SubItems[2].Text = "//"; // + CODE_COMMENT(LST_BYTE.Items[i].SubItems[1].Text); } // 
                    //  if (bbuffer == 33 || bbuffer == 34) { LV_CODE.Items[i].SubItems[2].Text); // = "//" + BIO2_FLAG_COMMENT(LST_BYTE.Items[i].SubItems[1].Text); }

                    //MessageBox.Show(i.ToString());


                    // break out and fix the wacky length

                    if (MAIN == false)
                    {
                        if (bbuffer == 0xFF) { break; }
                    }
                    else {
                      //  if (bbuffer == scdobj.short_skip) { break; }
                    }

                }


                br.Close();
                fs.Close();


            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }



        public static Dictionary<int, string> OFFSET_LUT = new Dictionary<int, string>()
        {
            {0, "Camera Switches"},
            {1, ".SCA COLLISONS"},
            {2, "??"},
            {3, "TMD/TIM"},
            {4, "Unknown"},
            {5, "Unknown"},
            {6, "Initialization Script (MAIN.SCD)"},
            {7, "Execution Script (SUB.SCD)"},
            {8, "Unknown"},
            {9, "skeleton"},
            {10, "skeleton anim steps"},
            {11, "Unknown"},
            {12, "Unknown"},
            {13, "Animation for Curretion Room"},
            {14, "Unknown"},
            {15, "Points to an offset to TIM Image"},
            {16, "RAW IMAGE?"},
            {17, "VAB FILE"},
            {18, "Offset to SOUND BANK"},
            {19, "Unknown"},

        };










    }





}
