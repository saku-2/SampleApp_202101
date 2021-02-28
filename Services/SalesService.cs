﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApp_202101.Services
{
    public class SalesService
    {
        //A 結果
        //なし　入力値
        public (int Astart, int Aend, int Asalesdate) Result(string start, string end, string salesDate)
        {
            // 営業日+-0.5年→S/E両方はいる
            // 外れたら、自動的に+-１年する
            int Astart = 0;
            int Aend = 0;
            int AsalesDate = 0;

            var startDate = DateTime.Parse(start);
            var endDate = DateTime.Parse(end);
            var salesDateTime = DateTime.Parse(salesDate);

            ////以下は、前後0.5年以上の差がある時
            ////営業日が７月～１２月　かつ　0.5年以上前にSTART
            //if ((salesDateTime.Year - startDate.Year) > 6 && (salesDateTime.Year >=7))
            //{
            //    //S・年 = 営・年
            //    Astart = salesDateTime.Year;
            //    //E・月　- S・月
            //    //１年以内
            //    //if ((endDate.Month - startDate.Month) == 1 || ((startDate.Month == 1) && ((endDate.Month - startDate.Month) == -11)))
            //    //{}
            //}
            //// 営業日が１月～６月　かつ　0.5年以上前にSTART
            //else if((salesDateTime.Year - startDate.Year) < -6 && (salesDateTime.Year <= 6))
            //{
            //    //S・年 = 営・年 - 1
            //    Astart = salesDateTime.Year - 1;
            //}
            //else//判定不能の時（１年以上の誤差がある時）
            //{
            //    Astart = salesDateTime.Year - 2;
            //}
            ////StartとEndは別々に算出する。
            ////営業日が７月～１２月　かつ　0.5年以上後にEND
            //if ((endDate.Year - salesDateTime.Year) > 6 && (endDate.Year >= 7))
            //{
            //    //E・年 = 営・年
            //    //不明だが、「S-E=1年以内」の条件より求まる。
            //    Aend = salesDateTime.Year;
            //}
            //// 営業日が１月～６月　かつ　0.5年以上後にEND
            //else if ((endDate.Year - salesDateTime.Year) < -6 && (endDate.Year <= 6))
            //{
            //    //E・年 = 営・年
            //    Aend = salesDateTime.Year + 1;
            //}
            //else//判定不能の時（１年以上の誤差がある時）
            //{
            //    Aend = salesDateTime.Year + 2;
            //}



            //if (salesDateTime.Month >=1 && salesDateTime.Month <= 6)
            //{
            //    if (startDate.Month >= 7)//年またぎ
            //    {
            //        Astart = salesDateTime.Year - 1;

            //        if(startDate.Month > endDate.Month)//年またぎ
            //        {
            //            Aend = salesDateTime.Year -1;
            //        }
            //        else
            //        {
            //            Aend = salesDateTime.Year -1;
            //        }
            //    }
            //    else
            //    {
            //        Astart = salesDateTime.Year;

            //        if (startDate.Month > endDate.Month)//年またぎ
            //        {
            //            Aend = salesDateTime.Year + 1;
            //        }
            //        else
            //        {
            //            Aend = salesDateTime.Year;
            //        }
            //    }
            //}
            //else if(salesDateTime.Month >= 7 && salesDateTime.Month <= 12)
            //{
            //    if (startDate.Month <= 6)//年またぎ
            //    {
            //        Astart = salesDateTime.Year + 1;

            //        if (startDate.Month > endDate.Month)//年またぎ
            //        {
            //            Aend = salesDateTime.Year + 2;
            //        }
            //        else
            //        {
            //            Aend = salesDateTime.Year + 1;
            //        }
            //    }
            //    else
            //    {
            //        Astart = salesDateTime.Year;

            //        if (startDate.Month > endDate.Month)//年またぎ
            //        {
            //            Aend = salesDateTime.Year + 1;
            //        }
            //        else
            //        {
            //            Aend = salesDateTime.Year;
            //        }
            //    }
            //}

            ////0.5年以上のキャンペーンはしない
            //if (startDate.Month >= endDate.Month)
            //{
            //    if (endDate.Month >= salesDateTime.Month)
            //    {
            //        Astart = salesDateTime.Year - 1;
            //        Aend = salesDateTime.Year;

            //    }
            //    else
            //    {
            //        Astart = salesDateTime.Year;
            //        Aend = salesDateTime.Year + 1;
            //    }
            //}
            //else
            //{
            //    Astart = salesDateTime.Year;
            //    Aend = salesDateTime.Year;
            //}

            //0.5年以上のキャンペーンはしない
            if (startDate.Month >= endDate.Month)//年
            {
                if (endDate.Month >= salesDateTime.Month)
                {
                    Astart = salesDateTime.Year - 1;
                    Aend = salesDateTime.Year;
                }
                else
                {
                    int val = (startDate.Month + 6);
                    if (val > 12)
                    {
                        val = val - 12;
                    }

                    if (salesDateTime.Month <= val)
                    {
                        Astart = salesDateTime.Year - 1;
                        Aend = salesDateTime.Year;
                    }
                    else
                    {
                    Astart = salesDateTime.Year;
                    Aend = salesDateTime.Year + 1;
                    }
                }
            }
            // 年またぎしないが、営業日が年またぎした
            else if (startDate.Month >= salesDateTime.Month)
            {
                Astart = salesDateTime.Year - 1;
                Aend = salesDateTime.Year - 1;
            }
            else
            {
                Astart = salesDateTime.Year;
                Aend = salesDateTime.Year;
            }

            AsalesDate = salesDateTime.Year;
            return (Astart, Aend, AsalesDate);
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="salesDate"></param>
        /// <returns></returns>
        public (int Astart, int Aend, int Asalesdate) Result2(string start, string end, string salesDate)
        {
            int Astart = 0;
            int Aend = 0;
            int AsalesDate = 0;

            var startDate = DateTime.Parse(start);
            var endDate = DateTime.Parse(end);
            var salesDateTime = DateTime.Parse(salesDate);

            //0.5年以上のキャンペーンはしない
            //if (startDate.Month > salesDateTime.Month)
            //{
            //    Astart = salesDateTime.Year;
            //    //Aend = salesDateTime.Year;
            //}
            //else if (endDate.Month < salesDateTime.Month)
            //{
            //    //Astart = salesDateTime.Year;
            //    Aend = salesDateTime.Year;
            //}
            if (startDate.Month >= endDate.Month)//年
            {
                //if(salesDateTime.Month < startDate.Month)
                //{
                //    Astart = salesDateTime.Year;
                //    Aend = salesDateTime.Year + 1;
                //}
                //S=営業日
                if (startDate.Month == salesDateTime.Month)
                {
                    Astart = salesDateTime.Year;
                    Aend = salesDateTime.Year + 1;
                }
                //E=営業日
                else if (endDate.Month == salesDateTime.Month)
                {
                    Astart = salesDateTime.Year - 1;
                    Aend = salesDateTime.Year;
                }
                else if ((salesDateTime.Month < startDate.Month) && (salesDateTime.Month < endDate.Month))
                {
                    Astart = salesDateTime.Year;
                    Aend = salesDateTime.Year + 1;
                }
                else if((startDate.Month > salesDateTime.Month) && (salesDateTime.Month > endDate.Month))
                {
                    Astart = salesDateTime.Year - 1;
                    Aend = salesDateTime.Year;
                }
                


                //if (endDate.Month >= salesDateTime.Month)
                //{
                //    Astart = salesDateTime.Year - 1;
                //    Aend = salesDateTime.Year;
                //}
                //else
                //{
                //    int val = (startDate.Month + 6);
                //    if (val > 12)
                //    {
                //        val = val - 12;
                //    }

                //    if (salesDateTime.Month <= val)
                //    {
                //        Astart = salesDateTime.Year - 1;
                //        Aend = salesDateTime.Year;
                //    }
                //    else
                //    {
                //        Astart = salesDateTime.Year;
                //        Aend = salesDateTime.Year + 1;
                //    }
                //}
            }
            // 年またぎしないが、営業日が年またぎした
            //else if (startDate.Month >= salesDateTime.Month)
            //{
            //    Astart = salesDateTime.Year - 1;
            //    Aend = salesDateTime.Year - 1;
            //}
            else
            {
                Astart = salesDateTime.Year;
                Aend = salesDateTime.Year;
            }

            AsalesDate = salesDateTime.Year;
            return (Astart, Aend, AsalesDate);
        }
    }
}