<html>
<head>
           <meta charset = 'utf-8'>
           <title>View Database Record</title>
           <link rel="stylesheet" type="text/css" href="L3TutoStyle.css"/>
           <script language="javascript" type="text/javascript" src="Special.js">
           </script>
</head>
<body>
<center>
<img src="TMC-Logo-3.jpg" margin="auto" width="370px" height="110px"></img>
</center>
<?php
print "<hr>";
print "<p>Edit Database Record</p>";

$host = "localhost";
$user = "root";
$passwd = "";
$database = "bucdb";
$table_name = "member";

$connect = mysqli_connect($host,$user,$passwd,$database) 
or die("could not connect to database");

mysqli_select_db($connect,$database);

$member_id =$_POST["m_id"];
$name =$_POST["edname"];
$student_id =$_POST["edsid"];
$phone_no=$_POST["edphone"];
$email =$_POST["edemail"];
$gender =$_POST["edgender"];

$sql="UPDATE $table_name SET m_name = '$name',s_id='$student_id',phone_no='$phone_no',
email='$email',gender='$email'WHERE id = '".$member_id."'";
if (!mysqli_query($connect,$sql))
{
die('Error: ' . mysqli_error($connect));
}
print "<p>Your information has been updated in the database</p>";
mysqli_close($connect);
?>
</body>
</html>