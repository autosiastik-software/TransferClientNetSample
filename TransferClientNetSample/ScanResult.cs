using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TransferClientNetSample
{
    internal class ScanResult
    {
        [JsonProperty("scan_id")]
        [JsonPropertyName("scan_id")]
        public Guid ScanId { get; set; }
        [JsonProperty("ez")]
        [JsonPropertyName("ez")]
        public string Ez { get; set; }
        [JsonProperty("ez_string")]
        [JsonPropertyName("ez_string")]
        public string EzString { get; set; }
        [JsonProperty("ez_img")]
        [JsonPropertyName("ez_img")]
        public string EzImg { get; set; }
        [JsonProperty("hsn")]
        [JsonPropertyName("hsn")]
        public string Hsn { get; set; }
        [JsonProperty("hsn_img")]
        [JsonPropertyName("hsn_img")]
        public string HsnImg { get; set; }
        [JsonProperty("tsn")]
        public string Tsn { get; set; }
        [JsonProperty("vsn")]
        public string Vsn { get; set; }
        [JsonProperty("field_2_2")]
        [JsonPropertyName("field_2_2")]
        public string Field22 { get; set; } // Feld 2.2
        [JsonProperty("field_2_2_img")]
        [JsonPropertyName("field_2_2_img")]
        public string Field22Img { get; set; }
        [JsonProperty("vin")]
        [JsonPropertyName("vin")]
        public string Vin { get; set; }
        [JsonProperty("vin_img")]
        [JsonPropertyName("vin_img")]
        public string VinImg { get; set; }
        [JsonProperty("d3")]
        [JsonPropertyName("d3")]
        public string D3 { get; set; }
        [JsonProperty("registrationNumber")]
        [JsonPropertyName("registrationNumber")]
        public string RegistrationNumber { get; set; }
        [JsonProperty("registrationNumber_img")]
        [JsonPropertyName("registrationNumber_img")]
        public string RegistrationNumberImg { get; set; }
        [JsonProperty("name1")]
        [JsonPropertyName("name1")]
        public string Name1 { get; set; }
        [JsonProperty("name1_img")]
        [JsonPropertyName("name1_img")]
        public string Name1Img { get; set; }
        [JsonProperty("name2")]
        [JsonPropertyName("name2")]
        public string Name2 { get; set; }
        [JsonProperty("name2_img")]
        [JsonPropertyName("name2_img")]
        public string Name2Img { get; set; }
        [JsonProperty("firstname")]
        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }
        [JsonProperty("firstname_img")]
        [JsonPropertyName("firstname_img")]
        public string FirstnameImg { get; set; }
        [JsonProperty("address1")]
        [JsonPropertyName("address1")]
        public string Address1 { get; set; }
        [JsonProperty("address1_img")]
        [JsonPropertyName("address1_img")]
        public string Address1Img { get; set; }
        [JsonProperty("address2")]
        [JsonPropertyName("address2")]
        public string Address2 { get; set; }
        [JsonProperty("address2_img")]
        [JsonPropertyName("address2_img")]
        public string Address2Img { get; set; }
        [JsonProperty("d3_img")]
        [JsonPropertyName("d3_img")]
        public string D3Img { get; set; }
        [JsonProperty("j")]
        [JsonPropertyName("j")]
        public string J { get; set; }
        [JsonProperty("j_img")]
        [JsonPropertyName("j_img")]
        public string JImg { get; set; }
        [JsonProperty("field_4")]
        [JsonPropertyName("field_4")]
        public string Field4 { get; set; }
        [JsonProperty("field_4_img")]
        [JsonPropertyName("field_4_img")]
        public string Field4Img { get; set; }
        [JsonProperty("field_3")]
        [JsonPropertyName("field_3")]
        public string Field3 { get; set; }
        [JsonProperty("field_3_img")]
        [JsonPropertyName("field_3_img")]
        public string Field3Img { get; set; }
        [JsonProperty("d1")]
        [JsonPropertyName("d1")]
        public string D1 { get; set; }
        [JsonProperty("d1_img")]
        [JsonPropertyName("d1_img")]
        public string D1Img { get; set; }
        [JsonProperty("d2_1")]
        [JsonPropertyName("d2_1")]
        public string D21 { get; set; }
        [JsonProperty("d2_1_img")]
        [JsonPropertyName("d2_1_img")]
        public string D21Img { get; set; }
        [JsonProperty("d2_2")]
        [JsonPropertyName("d2_2")]
        public string D22 { get; set; }
        [JsonProperty("d2_2_img")]
        [JsonPropertyName("d2_2_img")]
        public string D22Img { get; set; }
        [JsonProperty("d2_3")]
        [JsonPropertyName("d2_3")]
        public string D23 { get; set; }
        [JsonProperty("d2_3_img")]
        [JsonPropertyName("d2_3_img")]
        public string D23Img { get; set; }
        [JsonProperty("d2_4")]
        [JsonPropertyName("d2_4")]
        public string D24 { get; set; }
        [JsonProperty("d2_4_img")]
        [JsonPropertyName("d2_4_img")]
        public string D24Img { get; set; }
        [JsonProperty("field_2")]
        [JsonPropertyName("field_2")]
        public string Field2 { get; set; }
        [JsonProperty("field_2_img")]
        [JsonPropertyName("field_2_img")]
        public string Field2Img { get; set; }
        [JsonProperty("field_5_1")]
        [JsonPropertyName("field_5_1")]
        public string Field51 { get; set; }
        [JsonProperty("field_5_1_img")]
        [JsonPropertyName("field_5_1_img")]
        public string Field51Img { get; set; }
        [JsonProperty("field_5_2")]
        [JsonPropertyName("field_5_2")]
        public string Field52 { get; set; }
        [JsonProperty("field_5_2_img")]
        [JsonPropertyName("field_5_2_img")]
        public string Field52Img { get; set; }
        [JsonProperty("v9")]
        [JsonPropertyName("v9")]
        public string V9 { get; set; }
        [JsonProperty("v9_img")]
        [JsonPropertyName("v9_img")]
        public string V9Img { get; set; }
        [JsonProperty("field_14")]
        [JsonPropertyName("field_14")]
        public string Field14 { get; set; }
        [JsonProperty("field_14_img")]
        [JsonPropertyName("field_14_img")]
        public string Field14Img { get; set; }
        [JsonProperty("p3")]
        [JsonPropertyName("p3")]
        public string P3 { get; set; }
        [JsonProperty("p3_img")]
        [JsonPropertyName("p3_img")]
        public string P3Img { get; set; }
        [JsonProperty("field_10")]
        [JsonPropertyName("field_10")]
        public string Field10 { get; set; }
        [JsonProperty("field_10_img")]
        [JsonPropertyName("field_10_img")]
        public string Field10Img { get; set; }
        [JsonProperty("field_14_1")]
        [JsonPropertyName("field_14_1")]
        public string Field141 { get; set; }
        [JsonProperty("field_14_1_img")]
        [JsonPropertyName("field_14_1_img")]
        public string Field141Img { get; set; }
        [JsonProperty("p1")]
        [JsonPropertyName("p1")]
        public string P1 { get; set; }
        [JsonProperty("p1_img")]
        [JsonPropertyName("p1_img")]
        public string P1Img { get; set; }
        [JsonProperty("l")]
        [JsonPropertyName("l")]
        public string L { get; set; }
        [JsonProperty("l_img")]
        [JsonPropertyName("l_img")]
        public string LImg { get; set; }
        [JsonProperty("field_9")]
        [JsonPropertyName("field_9")]
        public string Field9 { get; set; }
        [JsonProperty("field_9_img")]
        [JsonPropertyName("field_9_img")]
        public string Field9Img { get; set; }
        [JsonProperty("p2_p4")]
        [JsonPropertyName("p2_p4")]
        public string P2P4 { get; set; }
        [JsonProperty("p2_p4_img")]
        [JsonPropertyName("p2_p4_img")]
        public string P2P4Img { get; set; }
        [JsonProperty("t")]
        [JsonPropertyName("t")]
        public string T { get; set; }
        [JsonProperty("t_img")]
        [JsonPropertyName("t_img")]
        public string TImg { get; set; }
        [JsonProperty("field_18")]
        [JsonPropertyName("field_18")]
        public string Field18 { get; set; }
        [JsonProperty("field_18_img")]
        [JsonPropertyName("field_18_img")]
        public string Field18Img { get; set; }
        [JsonProperty("field_19")]
        [JsonPropertyName("field_19")]
        public string Field19 { get; set; }
        [JsonProperty("field_19_img")]
        [JsonPropertyName("field_19_img")]
        public string Field19Img { get; set; }
        [JsonProperty("field_20")]
        [JsonPropertyName("field_20")]
        public string Field20 { get; set; }
        [JsonProperty("field_20_img")]
        [JsonPropertyName("field_20_img")]
        public string Field20Img { get; set; }
        [JsonProperty("g")]
        [JsonPropertyName("g")]
        public string G { get; set; }
        [JsonProperty("g_img")]
        [JsonPropertyName("g_img")]
        public string GImg { get; set; }
        [JsonProperty("field_12")]
        [JsonPropertyName("field_12")]
        public string Field12 { get; set; }
        [JsonProperty("field_12_img")]
        [JsonPropertyName("field_12_img")]
        public string Field12Img { get; set; }
        [JsonProperty("field_13")]
        [JsonPropertyName("field_13")]
        public string Field13 { get; set; }
        [JsonProperty("field_13_img")]
        [JsonPropertyName("field_13_img")]
        public string Field13Img { get; set; }
        [JsonProperty("q")]
        [JsonPropertyName("q")]
        public string Q { get; set; }
        [JsonProperty("q_img")]
        [JsonPropertyName("q_img")]
        public string QImg { get; set; }
        [JsonProperty("v7")]
        [JsonPropertyName("v7")]
        public string V7 { get; set; }
        [JsonProperty("v7_img")]
        [JsonPropertyName("v7_img")]
        public string V7Img { get; set; }
        [JsonProperty("f1")]
        [JsonPropertyName("f1")]
        public string F1 { get; set; }
        [JsonProperty("f1_img")]
        [JsonPropertyName("f1_img")]
        public string F1Img { get; set; }
        [JsonProperty("f2")]
        [JsonPropertyName("f2")]
        public string F2 { get; set; }
        [JsonProperty("f2_img")]
        [JsonPropertyName("f2_img")]
        public string F2Img { get; set; }
        [JsonProperty("field_7_1")]
        [JsonPropertyName("field_7_1")]
        public string Field71 { get; set; }
        [JsonProperty("field_7_1_img")]
        [JsonPropertyName("field_7_1_img")]
        public string Field71Img { get; set; }
        [JsonProperty("field_7_2")]
        [JsonPropertyName("field_7_2")]
        public string Field72 { get; set; }
        [JsonProperty("field_7_2_img")]
        [JsonPropertyName("field_7_2_img")]
        public string Field72Img { get; set; }
        [JsonProperty("field_7_3")]
        [JsonPropertyName("field_7_3")]
        public string Field73 { get; set; }
        [JsonProperty("field_7_3_img")]
        [JsonPropertyName("field_7_3_img")]
        public string Field73Img { get; set; }
        [JsonProperty("field_8_1")]
        [JsonPropertyName("field_8_1")]
        public string Field81 { get; set; }
        [JsonProperty("field_8_1_img")]
        [JsonPropertyName("field_8_1_img")]
        public string Field81Img { get; set; }
        [JsonProperty("field_8_2")]
        [JsonPropertyName("field_8_2")]
        public string Field82 { get; set; }
        [JsonProperty("field_8_2_img")]
        [JsonPropertyName("field_8_2_img")]
        public string Field82Img { get; set; }
        [JsonProperty("field_8_3")]
        [JsonPropertyName("field_8_3")]
        public string Field83 { get; set; }
        [JsonProperty("field_8_3_img")]
        [JsonPropertyName("field_8_3_img")]
        public string Field83Img { get; set; }
        [JsonProperty("u1")]
        [JsonPropertyName("u1")]
        public string U1 { get; set; }
        [JsonProperty("u1_img")]
        [JsonPropertyName("u1_img")]
        public string U1Img { get; set; }
        [JsonProperty("u2")]
        [JsonPropertyName("u2")]
        public string U2 { get; set; }
        [JsonProperty("u2_img")]
        [JsonPropertyName("u2_img")]
        public string U2Img { get; set; }
        [JsonProperty("u3")]
        [JsonPropertyName("u3")]
        public string U3 { get; set; }
        [JsonProperty("u3_img")]
        [JsonPropertyName("u3_img")]
        public string U3Img { get; set; }
        [JsonProperty("o1")]
        [JsonPropertyName("o1")]
        public string O1 { get; set; }
        [JsonProperty("o1_img")]
        [JsonPropertyName("o1_img")]
        public string O1Img { get; set; }
        [JsonProperty("o2")]
        [JsonPropertyName("o2")]
        public string O2 { get; set; }
        [JsonProperty("o2_img")]
        [JsonPropertyName("o2_img")]
        public string O2Img { get; set; }
        [JsonProperty("s1")]
        [JsonPropertyName("s1")]
        public string S1 { get; set; }
        [JsonProperty("s1_img")]
        [JsonPropertyName("s1_img")]
        public string S1Img { get; set; }
        [JsonProperty("s2")]
        [JsonPropertyName("s2")]
        public string S2 { get; set; }
        [JsonProperty("s2_img")]
        [JsonPropertyName("s2_img")]
        public string S2Img { get; set; }
        [JsonProperty("field_15_1")]
        [JsonPropertyName("field_15_1")]
        public string Field151 { get; set; }
        [JsonProperty("field_15_1_img")]
        [JsonPropertyName("field_15_1_img")]
        public string Field151Img { get; set; }
        [JsonProperty("field_15_2")]
        [JsonPropertyName("field_15_2")]
        public string Field152 { get; set; }
        [JsonProperty("field_15_2_img")]
        [JsonPropertyName("field_15_2_img")]
        public string Field152Img { get; set; }
        [JsonProperty("field_15_3")]
        [JsonPropertyName("field_15_3")]
        public string Field153 { get; set; }
        [JsonProperty("field_15_3_img")]
        [JsonPropertyName("field_15_3_img")]
        public string Field153Img { get; set; }
        [JsonProperty("r")]
        [JsonPropertyName("r")]
        public string R { get; set; }
        [JsonProperty("r_img")]
        [JsonPropertyName("r_img")]
        public string RImg { get; set; }
        [JsonProperty("field_11")]
        [JsonPropertyName("field_11")]
        public string Field11 { get; set; }
        [JsonProperty("field_11_img")]
        [JsonPropertyName("field_11_img")]
        public string Field11Img { get; set; }
        [JsonProperty("k")]
        [JsonPropertyName("k")]
        public string K { get; set; }
        [JsonProperty("k_img")]
        [JsonPropertyName("k_img")]
        public string KImg { get; set; }
        [JsonProperty("field_6")]
        [JsonPropertyName("field_6")]
        public string Field6 { get; set; }
        [JsonProperty("field_6_img")]
        [JsonPropertyName("field_6_img")]
        public string Field6Img { get; set; }
        [JsonProperty("field_17")]
        [JsonPropertyName("field_17")]
        public string Field17 { get; set; }
        [JsonProperty("field_17_img")]
        [JsonPropertyName("field_17_img")]
        public string Field17Img { get; set; }
        [JsonProperty("field_16")]
        [JsonPropertyName("field_16")]
        public string Field16 { get; set; }
        [JsonProperty("field_16_img")]
        [JsonPropertyName("field_16_img")]
        public string Field16Img { get; set; }
        [JsonProperty("field_21")]
        [JsonPropertyName("field_21")]
        public string Field21 { get; set; }
        [JsonProperty("field_21_img")]
        [JsonPropertyName("field_21_img")]
        public string Field21Img { get; set; }
        [JsonProperty("hu")]
        [JsonPropertyName("hu")]
        public string Hu { get; set; }
        [JsonProperty("hu_img")]
        [JsonPropertyName("hu_img")]
        public string HuImg { get; set; }
        [JsonProperty("maker")]
        [JsonPropertyName("maker")]
        public string Maker { get; set; }
        [JsonProperty("model")]
        [JsonPropertyName("model")]
        public string Model { get; set; }
        [JsonProperty("power_kw")]
        [JsonPropertyName("power_kw")]
        public int? PowerKw { get; set; }
        [JsonProperty("power_hp_kw")]
        [JsonPropertyName("power_hp_kw")]
        public string PowerHpKw { get; set; }
        [JsonProperty("ccm")]
        [JsonPropertyName("ccm")]
        public int? Ccm { get; set; }
        [JsonProperty("fuel")]
        [JsonPropertyName("fuel")]
        public string Fuel { get; set; }
        [JsonProperty("fuel_code")]
        [JsonPropertyName("fuel_code")]
        public string FuelCode { get; set; }

        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
