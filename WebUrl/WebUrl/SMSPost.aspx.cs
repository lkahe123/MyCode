using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;

namespace WebUrl
{
    public partial class SMSPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (1 == 2)
            {
                IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", "LTAI4FhvagdVU5NnoSzwdS6j", "4bR854vHtU2IRBlefeyn5avSx1fQDF");
                DefaultAcsClient client = new DefaultAcsClient(profile);
                CommonRequest request = new CommonRequest();
                request.Method = MethodType.POST;
                request.Domain = "dysmsapi.aliyuncs.com";
                request.Version = "2017-05-25";
                request.Action = "SendSms";
                // request.Protocol = ProtocolType.HTTP;
                request.AddQueryParameters("PhoneNumbers", "15221319981");
                request.AddQueryParameters("SignName", "个人信息管理平台");
                request.AddQueryParameters("TemplateCode", "SMS_173472920");
                request.AddQueryParameters("TemplateParam", "{\"code\":\"2233\"}");
                try
                {
                    CommonResponse response = client.GetCommonResponse(request);
                    Console.WriteLine(System.Text.Encoding.Default.GetString(response.HttpResponse.Content));
                }
                catch (ServerException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (ClientException ex)
                {
                    Console.WriteLine(ex);
                }
            }

        }
    }
}