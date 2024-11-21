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
?>

<p>Please enter the Member ID you want to edit</p>
<form name="AdminEditForm1" action ="AdminEdit1.php" method="post">
<table>
<tr>
<td>Member ID</td>
<td><input type="text" name="m_id" size="10"></td>
</tr>
<tr>
<td colspan="2"><input type="submit" value="submit"/>
                <input type="reset" value="Reset Form"/></td>
</tr>
</table>
</form>
</body>
</html>