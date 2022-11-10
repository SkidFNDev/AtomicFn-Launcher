using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using AtomicLauncher;
using Newtonsoft.Json.Linq;
using RestSharp;

// Token: 0x0200000D RID: 13
internal class Class5
{
	// Token: 0x06000038 RID: 56 RVA: 0x000040CC File Offset: 0x000022CC
	public static string smethod_0()
	{
		RestClient restClient = new RestClient("https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/token");
		RestRequest restRequest = new RestRequest(1);
		restRequest.AddHeader("Authorization", "Basic OThmN2U0MmMyZTNhNGY4NmE3NGViNDNmYmI0MWVkMzk6MGEyNDQ5YTItMDAxYS00NTFlLWFmZWMtM2U4MTI5MDFjNGQ3");
		restRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
		restRequest.AddParameter("grant_type", "client_credentials");
		RestRequest restRequest2 = restRequest;
		string[] array = restClient.Execute(restRequest2).Content.Split(new char[]
		{
			':'
		}, 26);
		string result;
		try
		{
			result = array[1].ToString().Split(new char[]
			{
				','
			}, 2)[0].ToString().Split(new char[]
			{
				'"'
			}, 2)[1].ToString().Split(new char[]
			{
				'"'
			}, 2)[0].ToString();
		}
		catch
		{
			MessageBox.Show("To login you want to be connected to the internet.");
			Process.GetCurrentProcess().Kill();
			result = "error";
		}
		return result;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x000041C4 File Offset: 0x000023C4
	public static string smethod_1(string string_0)
	{
		RestClient restClient = new RestClient("https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/deviceAuthorization");
		RestRequest restRequest = new RestRequest(1);
		restRequest.AddHeader("Authorization", "Bearer " + string_0);
		restRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
		RestRequest restRequest2 = restRequest;
		string[] array = restClient.Execute(restRequest2).Content.Split(new char[]
		{
			','
		}, 8);
		string[] array2 = array[3].ToString().Split(new char[]
		{
			'"'
		}, 4)[3].ToString().Split(new char[]
		{
			'"'
		}, 2);
		string[] array3 = array[1].ToString().Split(new char[]
		{
			'"'
		}, 4)[3].ToString().Split(new char[]
		{
			'"'
		}, 2);
		Process.Start(array2[0]);
		string content;
		for (;;)
		{
			RestClient restClient2 = new RestClient("https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/token");
			RestRequest restRequest3 = new RestRequest(1);
			restRequest3.AddHeader("Authorization", "Basic OThmN2U0MmMyZTNhNGY4NmE3NGViNDNmYmI0MWVkMzk6MGEyNDQ5YTItMDAxYS00NTFlLWFmZWMtM2U4MTI5MDFjNGQ3");
			restRequest3.AddHeader("Content-Type", "application/x-www-form-urlencoded");
			restRequest3.AddParameter("grant_type", "device_code");
			restRequest3.AddParameter("device_code", array3[0].ToString());
			RestRequest restRequest4 = restRequest3;
			content = restClient2.Execute(restRequest4).Content;
			if (!content.Contains("errors"))
			{
				JObject jobject = JObject.Parse(content);
				Settings.Default.Accid = jobject["in_app_id"].ToString();
				Settings.Default.Save();
			}
			if (content.Contains("access_token"))
			{
				break;
			}
			content.Contains("errors.com.epicgames.not_found");
			Thread.Sleep(150);
		}
		string[] array4 = content.Split(new char[]
		{
			':'
		}, 26);
		return array4[1].ToString().Split(new char[]
		{
			','
		}, 2)[0].ToString().Split(new char[]
		{
			'"'
		}, 2)[1].ToString().Split(new char[]
		{
			'"'
		}, 2)[0].ToString() + "," + array4[16].ToString().Split(new char[]
		{
			','
		}, 2)[0];
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000441C File Offset: 0x0000261C
	public static string smethod_2(string string_0)
	{
		Console.WriteLine("Token wird angefragt");
		RestClient restClient = new RestClient("https://account-public-service-prod.ol.epicgames.com/account/api/oauth/token");
		RestRequest restRequest = new RestRequest(1);
		restRequest.AddHeader("Authorization", "basic OThmN2U0MmMyZTNhNGY4NmE3NGViNDNmYmI0MWVkMzk6MGEyNDQ5YTItMDAxYS00NTFlLWFmZWMtM2U4MTI5MDFjNGQ3");
		restRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
		restRequest.AddParameter("grant_type", "authorization_code");
		restRequest.AddParameter("code", string_0);
		RestRequest restRequest2 = restRequest;
		string content = restClient.Execute(restRequest2).Content;
		string result;
		if (content.Contains("access_token"))
		{
			string[] array = content.Split(new char[]
			{
				':'
			}, 26);
			string str = array[17].ToString().Split(new char[]
			{
				','
			}, 2)[0];
			result = array[1].ToString().Split(new char[]
			{
				','
			}, 2)[0].ToString().Split(new char[]
			{
				'"'
			}, 2)[1].ToString().Split(new char[]
			{
				'"'
			}, 2)[0].ToString() + "," + str;
		}
		else if (!content.Contains("It is possible that it was no longer valid"))
		{
			MessageBox.Show(content);
			result = "error";
		}
		else
		{
			MessageBox.Show("An Error occured, pls try again at a later point.");
			Process.Start("https://www.epicgames.com/id/logout?redirectUrl=https%3A//www.epicgames.com/id/login%3FredirectUrl%3Dhttps%253A%252F%252Fwww.epicgames.com%252Fid%252Fapi%252Fredirect%253FclientId%253D3446cd72694c4a4485d81b77adbb2141%2526responseType%253Dcode");
			result = "error";
		}
		return result;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00004578 File Offset: 0x00002778
	public static string smethod_3(string string_0)
	{
		RestClient restClient = new RestClient("https://account-public-service-prod.ol.epicgames.com/account/api/oauth/exchange");
		RestRequest restRequest = new RestRequest(0);
		restRequest.AddHeader("Authorization", "bearer " + string_0);
		RestRequest restRequest2 = restRequest;
		string content = restClient.Execute(restRequest2).Content;
		Console.WriteLine(content);
		string result;
		if (!content.Contains("errors.com.epicgames.common.oauth.invalid_token"))
		{
			result = content.Split(new char[]
			{
				','
			}, 4)[1].ToString().Split(new char[]
			{
				','
			}, 2)[0].ToString().Split(new char[]
			{
				'"'
			}, 2)[1].ToString().Split(new char[]
			{
				'"'
			}, 2)[1].ToString().Split(new char[]
			{
				'"'
			}, 2)[1].ToString().Split(new char[]
			{
				'"'
			}, 2)[0].ToString();
		}
		else
		{
			result = "error";
		}
		return result;
	}
}
