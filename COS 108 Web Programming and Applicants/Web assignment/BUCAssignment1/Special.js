function validate() {
 var fname = document.forms["registerForm"]["fname"].value;
 if(fname==""){
 alert("Please enter the name");
 return false;
 } 
 var nric = document.forms["registerForm"]["nric"].value;
 if(nric==""){
 alert("Please enter the NRIC");
 return false;
 } 
 var telno = document.forms["registerForm"]["telno"].value;
 if(telno==""){
 alert("Please enter the telephone number");
 return false;
 }else{
 if(isNaN(telno)){
 alert("telephone number not valid");
 return false;
 }
 }  
 var email = document.forms["registerForm"]["email"].value;
 if(email==""){
 alert("Please enter the email");
 return false; }
else
{
var validFormat= /^([a-zA-Z0-9_.-])+@(([a-zA-Z0-9-])+.)+([a-zA-Z0-9]{2,4})+$/;
if (!validFormat.test(email)) {
        alert('Please enter a valid e-mail address.');
        return false;
 } 
 } 
 }
