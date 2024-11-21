<!DOCTYPE html>  
<html>  
<head>  
<style>  
.error {color: #FF0001;}  
</style>  
</head>  
<body>    
  
<?php  
// define variables to empty values  
$nameErr = $emailErr = $mobilenoErr = "";  
$name = $email = $mobileno = "";  
  
//Input fields validation  
if ($_SERVER["REQUEST_METHOD"] == "POST") {  
      
//String Validation  
    if (empty($_POST["name"])) {  
         $nameErr = "Name is required";  
    } else {  
        $name = input_data($_POST["name"]);  
            // check if name only contains letters and whitespace  
            if (!preg_match("/^[a-zA-Z ]*$/",$name)) {  
                $nameErr = "Only alphabets and white space are allowed";  
            }  
    }  
      
    //Email Validation   
    if (empty($_POST["email"])) {  
            $emailErr = "Email is required";  
    } else {  
            $email = input_data($_POST["email"]);  
            // check that the e-mail address is well-formed  
            if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {  
                $emailErr = "Invalid email format";  
            }  
     }  
    
    //Number Validation  
    if (empty($_POST["mobileno"])) {  
            $mobilenoErr = "Mobile no is required";  
    } else {  
            $mobileno = input_data($_POST["mobileno"]);  
            // check if mobile no is well-formed  
            if (!preg_match ("/^[0-9]*$/", $mobileno) ) {  
            $mobilenoErr = "Only numeric value is allowed.";  
            } 
    }  
}
function input_data($data) {  
    $data = trim($data);  
    $data = stripslashes($data);  
    $data = htmlspecialchars($data);  
    return $data;  
  }  
  ?>
  <h2>Registration Form</h2>  
<span class = "error">* required field </span>  
<br><br>  
<form name = "RegForm" method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>">    
    Name:   
    <input type="text" name="name">  
    <span class="error">* <?php echo $nameErr; ?> </span>  
    <br><br>  
    E-mail:   
    <input type="text" name="email">  
    <span class="error">* <?php echo $emailErr; ?> </span>  
    <br><br>  
    Mobile No:   
    <input type="text" name="mobileno">  
    <span class="error">* <?php echo $mobilenoErr; ?> </span>  
    <br><br>  
    <input type="submit" name="submit" value="Submit">   
    <br><br>                             
</form>
<?php  
    if(isset($_POST['submit'])) 
    {  
    if($nameErr == "" && $emailErr == "" && $mobilenoErr == "") { 
        $host = "localhost";
        $user = "root";
        $passwd = "";
        $database = "productdb";
        $table_name = "testvalid";

        $connect = mysqli_connect($host,$user,$passwd,$database) 
        or die("could not connect to database");

        $sql="INSERT INTO $table_name(name,email,mobileno)
        VALUES('$_POST[name]','$_POST[email]','$_POST[mobileno]')";
       
        if(!mysqli_query($connect,$sql))
        {
            die('Error: ' . mysqli_error($connect));
        }
        else{
            echo "1 record added";
            echo "<h3 color = #FF0001> <b>You have sucessfully registered.</b> </h3>";
        }
        mysqli_close($connect);       
    }else 
       {  
        echo "<h3> <b>You didn't filled up the form correctly.</b> </h3>";  
       } 
}
?>  
</body>
</html>
