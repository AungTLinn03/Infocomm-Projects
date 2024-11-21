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
print "<p>View Database Record</p>";

$host = "localhost";
$user = "root";
$passwd = "";
$database = "bucdb";
$table_name = "member";
$connect = mysqli_connect($host,$user,$passwd,$database) 
            or die("could not connect to database");

$query = "SELECT * FROM $table_name";
mysqli_select_db($connect,$database);
$result = mysqli_query($connect,$query);

if ($result) {
    print "<table border=1>";
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
mysqli_close($connect);
?>
</body>
</html>