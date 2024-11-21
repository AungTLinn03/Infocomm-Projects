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
<p>
<nav>
   <div class="topnav" id="myTopnav">
        <a href="AdminView.php">View Members</a>
      <a href="AdminAdd.html">Add New Member</a>
      <a href="AdminEdit.php">Edit Member</a>
      <a href="AdminDelete.php">Delete Member</a>
      <a href="Log_out.php">Log Out</a>      
   </div>
</nav>
</p>
</center>
<?php
//print "<p>Edit Database Record</p>";

$host = "localhost";
$user = "root";
$passwd = "";
$database = "tennis";
$table_name = "member";

$connect = mysqli_connect($host,$user,$passwd,$database) 
           or die("could not connect to database");

$member_id = $_POST["m_id"];
$query = "SELECT * FROM $table_name WHERE Mid='".$member_id."'";
mysqli_select_db($connect,$database);
$result = mysqli_query($connect,$query);
$myrow = mysqli_fetch_array($result,MYSQLI_ASSOC);

$member_id=$myrow['Mid'];
$name=$myrow['Name'];
$student_id=$myrow['Sid'];
$phone_no=$myrow['Contact_no'];
$email=$myrow['Email'];
$gender=$myrow['Gender'];

echo "<div class=entries>";
echo "<h3 align=center>Edit Database Record</h3>";
if (!$myrow)
{
  print "<center><p>No such record</p></center>";
}
else 
{
print "<center>";
print "<form name='AdminEditForm2' action ='AdminEdit2.php' method='post'>
<table>
<tr><td>Member ID</td><td>Mid<input type='hidden' name='m_id' value='$Mid'
></td></tr>
<tr><td>Name</td><td><input type='text' name='edname' value='$Name'></td></tr>
<tr><td>Student_ID</td><td><input type='text' name='edsid' value='$Sid'></td></tr>
<tr><td>Contact_no</td><td><input type='text' name='edphone' value='$Contact_no'></td></tr>
<tr><td>Email</td><td><input type='text' name='edemail' value='$Email'></td></tr>
<tr><td>Gender</td><td><input type='text' name='edgender' value='$Gender'></td></tr>
<tr><td><input type='submit' value='submit'>
<input type='reset' value='Reset Form'></td>
</tr>
</table>
</form>";
print "</center>";
}
mysqli_close($connect);
echo "</div>";
?>
</body>
</html>