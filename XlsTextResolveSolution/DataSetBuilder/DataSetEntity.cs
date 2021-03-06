﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataSetCreater
{
    public class DataSetEntity
    {
        public List<string> StrList { get; set; }
        public TableFilds Field { get; set; }
    }

    public enum TableName
    {
        import_clnt_example,
        import_update_comisiya
    }

    public enum TableFilds
    {
        c_name_f,
        c_name_i,
        c_name_o,
        inn,
        edrpou,
        dogovor_id,
        id_in_bank,
        account_for_credit,
        dogovor_date,
        start_date,
        stop_date,
        d_email,
        credit_valyuta,
        currency_text,
        end_of_reg,
        reg_num,
        credit_product,
        credit_sum,
        credit_procent,
        anuitet_sum,
        anuitet_date,
        c_birth_date,
        c_birth_place,
        pasport_seria,
        pasport_number,
        pasport_vidan,
        pasport_date,
        dolg_telo,
        dolg_procent,
        dolg_komis,
        rest_telo,
        rest_procent,
        rest_komis,
        penya_bank,
        total_dolg,
        dolg_creat_date,
        dolg_period,
        last_payment_date,
        c_p_index,
        c_p_region,
        c_p_area,
        c_p_city,
        c_p_street,
        c_p_dom,
        c_p_korpus,
        c_p_apartment,
        c_f_index,
        c_f_region,
        c_f_area,
        c_f_city,
        c_f_street,
        c_f_dom,
        c_f_korpus,
        c_f_apartment,
        c_r_index,
        c_r_region,
        c_r_area,
        c_r_city,
        c_r_street,
        c_r_dom,
        c_r_korpus,
        c_r_apartment,
        c_work_name,
        c_w_position,
        c_w_index,
        c_w_region,
        c_w_area,
        c_w_city,
        c_w_street,
        c_w_dom,
        c_w_korpus,
        c_w_apartment,
        c_phone_p_home,
        c_phone_f_home,
        c_phone_work,
        c_phone_mobile,
        bank_mfo,
        id_sozaem,
        unique_id,
        deal_id,
        additional_info,
        sex,
        comission,
        car_brand,
        car_year,
        car_number
    }
}
