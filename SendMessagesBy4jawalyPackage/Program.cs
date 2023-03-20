using ForJawalySMSHelper;
using ForJawalySMSHelper.Models;

ForJawalySMS.app_key = "app key";
ForJawalySMS.app_secret = "app secret";
ForJawalySMS.sender = "sender name";

var root = new Root()
{
    text = "text",
    numbers = new List<string>()
    {
        "XXXXXXXXXXX",
    }
};

var result = await ForJawalySMS.SendSms(root);
Console.WriteLine(result.message);
Console.ReadKey();

