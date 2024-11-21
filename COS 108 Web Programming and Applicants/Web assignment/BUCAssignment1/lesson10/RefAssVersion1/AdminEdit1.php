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

$member_id = $_POST["m_id"];
$query = "SELECT * FROM $table_name WHERE id='".$member_id."'";
mysqli_select_db($connect,$database);
$result = mysqli_query($connect,$query);
$myrow = mysqli_fetch_array($result,MYSQLI_ASSOC);

$member_id=$myrow['id'];
$name=$myrow['m_name'];
$student_id=$myrow['s_id'];
$phone_no=$myrow['phone_no'];
$email=$myrow['email'];
$gender=$myrow['gender'];
if (!$myrow)
{
  print "<p>No such record</p>";
}
else 
{
print "<form name='AdminEditForm2' action ='AdminEdit2.php' method='post'>
<table>
<tr><td>Product ID</td><td>$member_id<input type='hidden' name='m_id' value='$member_id'
></td></tr>
<tr><td>Name</td><td><input type='text' name='edname' value='$name'></td></tr>
<tr><td>Student_ID</td><td><input type='text' name='edsid' value='$student_id'></td></tr>
<tr><td>Phone_No</td><td><input type='text' name='edphone' value='$phone_no'></td></tr>
<tr><td>Email</td><td><input type='text' name='edemail' value='$email'></td></tr>
<tr><td>Gender</td><td><input type='text' name='edgender' value='$gender'></td></tr>
<tr><td><input type='submit' value='submit' >
<input type='reset' value='Reset Form'></td>
</tr>
</table>
</form>";
}
mysqli_close($connect);
?>
</body>
</html>