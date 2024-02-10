The Describe Compiler AWS is Amazon Web Services Lambda function project. It is built for hosting the Describe Compiler as a microservice, in the form of a lambda function. The project is licensed under the [AGPL v3](https://www.gnu.org/licenses/agpl-3.0) public license.

Project is under development. Here is how we call it from PHP, it at the moment.

```
//get all the articles
$code = "";
$sql = "SELECT name, content, timestamp FROM files";
echo "Executing query - '" . $sql . "'<br>";
$result = mysqli_query($conn, $sql);
if($result == false || mysqli_num_rows($result) < 1) die("Query result is false");
while ($row = mysqli_fetch_assoc($result))
{
	$code .= $row['name'] . "~~N~~" . $row['content'] . "~~~FILE~~~";
}

// test POST
$base64 = base64_encode($code);
$base64Name = base64_encode("MULTISTRING");
$result = doPostRequest('https://??????????.execute-api.eu-north-1.amazonaws.com/', $base64, $base64Name);
var_dump($result);
logPostResponse($result);
die("<br>End Testing POST.");

// functions
function doPostRequest($url, $code, $filename) {

	//https://stackoverflow.com/questions/5647461/how-do-i-send-a-post-request-with-php
	$data = [
		'command' => 'multi-parse', 
		'verbosity' => 'low',
		'translator' => 'JSON',
		'filename' => $filename,
		'code' => $code
	];

	// use key 'http' even if you send the request to https://...
	$options = [
		'http' => [
			'header' => "Content-type: application/x-www-form-urlencoded\r\n",
			'method' => 'POST',
			'content' => http_build_query($data),
		],
	];

	$context = stream_context_create($options);
	$result = file_get_contents($url, false, $context);
	return $result;
}
function logPostResponse($response) {

	if ($response == null) 
	{
		echo "ERROR : <span style='color:blue'>response is NULL</span><br />";
		return;
	}

	//echo $response;
	//var_dump($jArr);
	$jArr = json_decode($response, true);

	//json.Result
	if ($jArr["Result"] == null) echo "Result : <span style='color:blue'>NULL</span><br />";
	else echo "Result : <span style='color:blue'>" . $jArr["Result"] . "</span><br />";
	//echo "<br />";

	//json.Command
	if ($jArr["Command"] == null) echo "Command : <span style='color:blue'>NULL</span><br />";
	else echo "Command : <span style='color:blue'>" . $jArr["Command"] . "</span><br />";
	echo "<br /><br />";

	//json.Logs
	if ($jArr["Logs"] == null) echo "Logs : <span style='color:blue'>NULL</span><br />";
	else echo "Logs :<br /><span style='color:green'>" . $jArr["Logs"] . "</span><br /><br />";
	echo "<br />";
	
	//json.Json
	if ($jArr["Json"] == null) echo "Json : <span style='color:blue'>NULL</span><br />";
	else echo "Json :<br /><span style='color:blue'>" . $jArr["Json"] . "</span><br />";
	echo "<br />";
}
```

### Links
[[Describe Compilation | https://github.com/viktorchernev/DescribeCompiler/wiki/Compiler-how-to]]  
[[Use the CLI version | https://github.com/viktorchernev/DescribeCompiler/wiki/CliCompiler-how-to]]  
[[Use the API version | https://github.com/viktorchernev/DescribeCompiler/wiki/ApiCompiler-how-to]]  
