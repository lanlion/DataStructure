using System;
using System.Collections.Generic;
using System.Net.Http;

namespace com.baidu.ai
{
    public static class AccessToken

    {
        //{"refresh_token":"25.3796830e03a74fe8196f60dfea2982c8.315360000.1869963868.282335-15949125",
        //"expires_in":2592000,
        //"session_key":"9mzdDoUvCnbLCBNqU5\/Dio4ARKrGd0znQhyw2Lsag1c0I\/1p0uNeFp9f\/N36dbiF2aiYXg\/aBR+A3lkmRpN+xjMyCVP1dA==",
        //"access_token":"24.57af86e44d589fbefd1c2dd7c2d7291b.2592000.1557195868.282335-15949125",
        //"scope":"public vis-classify_dishes vis-classify_car brain_all_scope vis-classify_animal vis-classify_plant brain_object_detect brain_realtime_logo brain_dish_detect brain_car_detect brain_animal_classify brain_plant_classify brain_ingredient brain_advanced_general_classify brain_custom_dish brain_poi_recognize wise_adapt lebo_resource_base lightservice_public hetu_basic lightcms_map_poi kaidian_kaidian ApsMisTest_Test\u6743\u9650 vis-classify_flower lpq_\u5f00\u653e cop_helloScope ApsMis_fangdi_permission smartapp_snsapi_base iop_autocar oauth_tp_app smartapp_smart_game_openapi oauth_sessionkey smartapp_swanid_verify smartapp_opensource_openapi",
        //"session_secret":"0b95af53623533f190d3ddfc6a6aa443"}
        // 调用getAccessToken()获取的 access_token建议根据expires_in 时间 设置缓存
        // 返回token示例
        public static String TOKEN = "24.57af86e44d589fbefd1c2dd7c2d7291b.2592000.1557195868.282335-15949125";

        // 百度云中开通对应服务应用的 API Key 建议开通应用的时候多选服务
        private static String clientId = "pMIeS9V1xxukbzR2qnNXogg0";
        // 百度云中开通对应服务应用的 Secret Key
        private static String clientSecret = "muh4e5A0TfwQMg6chTtBhmZ8taWimed5";

        public static String getAccessToken()
        {
            String authHost = "https://aip.baidubce.com/oauth/2.0/token";
            HttpClient client = new HttpClient();
            List<KeyValuePair<String, String>> paraList = new List<KeyValuePair<string, string>>();
            paraList.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            paraList.Add(new KeyValuePair<string, string>("client_id", clientId));
            paraList.Add(new KeyValuePair<string, string>("client_secret", clientSecret));

            HttpResponseMessage response = client.PostAsync(authHost, new FormUrlEncodedContent(paraList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            return result;
        }
    }
}