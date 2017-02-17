using System;
using Foundation;
using WeChat.iOS;

namespace WeChat.iOS.Samples
{
	public class WeChatAPI: WXApiDelegate
	{
		//微信登录
		public bool Log(string appID)
		{
			var result = WXApi.RegisterApp(appID);
			return result;
		}
		//微信链接打开
		public bool Open(NSUrl url)
		{
			var result = WXApi.HandleOpenURL(url, this);
			return result;
		}
		//请求打开微信
		public override void OnReq(BaseReq req)
		{

		}
		//响应微信
		public override void OnResp(BaseResp resp)
		{

		}

		//发送信息到朋友圈
		public bool SendText(string text)
		{
			SendMessageToWXReq req = new SendMessageToWXReq();
			req.Text = text;
			req.BText = true;
			req.Scene = 1;
			WXApi.SendReq(req);

			return true;
		}

	}
}
