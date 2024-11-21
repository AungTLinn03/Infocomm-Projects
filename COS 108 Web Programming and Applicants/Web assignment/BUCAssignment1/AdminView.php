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
   <p>
   <p>
   <p>
   <p>
   <p>
   <p>
   
   <div class="chimp">
<?php
$host = "localhost";
$user = "root";
$passwd = "";
$database = "tennis";
$table_name = "member";
$connect = mysqli_connect($host,$user,$passwd,$database) 
            or die("could not connect to database");

$query = "SELECT * FROM $table_name";
mysqli_select_db($connect,$database);
$result = mysqli_query($connect,$query);

echo "<div>";
echo "<h1 align=center>Member List</h1>";


if ($result) {
    print "<table align=center border=3>";
    print "<th>Member_id<th>Name<th>Student_ID<th>Phone_No<th>EMail<th>Gender";
    while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC))
    {
    print "<tr>";
     foreach ($row as $field) 
     {
       print "<td>$field</td> ";
     }
     print "</tr>";
    }
}
else 
{ 
    die ("Query=$query failed!"); 
}
echo "</div>" ;
mysqli_close($connect);
?>
</div>
</body>
</html>