using System.Net;

//Create a request for the URL
WebRequest request = WebRequest.Create("http://www.contoso.com/default.html");

//If required by the server, set the credentialsl
request.Credentials = CredentialCache.DefaultCredentials;

//Get the response
HttpWebResponse response = (HttpWebResponse)request.GetResponse();

//Display the status
Console.WriteLine("Status: " + response.StatusDescription);
Console.WriteLine(new string('*', 50));

//Get the stream containing content returned by the server
Stream stream = response.GetResponseStream();

//Open the stream using a StreamReader for easy access
StreamReader reader = new(stream);

//Read the content
string responseFromServer = reader.ReadToEnd();

//Display the content
Console.WriteLine(responseFromServer);
Console.WriteLine(new string('*', 50));

//Cleanup the streams and the reponse
reader.Close();
stream.Close();
response.Close();