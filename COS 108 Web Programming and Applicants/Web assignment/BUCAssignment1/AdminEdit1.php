<html>
<head>
           <meta charset = 'utf-8'>
           <title>TMC Tennis Club</title>
           <link rel="stylesheet" type="text/css" href="L3TutoStyle.css"/>
           <script language="javascript" type="text/javascript" src="Special.js">
           </script>
           <style>
            body{
             background-image:url('../BUCAssignment1/purpleback.jpg');
             background-position:cover;
             background-repeat: no repeat;
             background-position: center;
             height:100%;
             width:100%;
             
             
             }
           </style>
</head>
<body>
<nav>
   
           <div class="nav-links" id="navLinks">
           <a href="AdminView.php">View Members</a>
           <a href="AdminAdd.php">Add New Member</a>
           <a href="AdminEdit.php">Edit Member</a>
           <a href="AdminDelete.php">Delete Member</a>
           <a href="Log_out.php">Log Out</a>      
      </div>
   </nav>
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

echo "<div class=chimp>";
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
<tr><td>Member Id</td><td>$member_id<input type='hidden' name='m_id' value='$member_id'
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
print "</center>";
}
mysqli_close($connect);
echo "</div>";
?>
</body>
</html>