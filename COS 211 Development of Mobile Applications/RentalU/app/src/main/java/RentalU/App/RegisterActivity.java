package RentalU.App;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Log;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;

public class RegisterActivity extends AppCompatActivity {

    TextInputLayout name,email,phone,password,confirm,gender;
    TextInputEditText nameEdit,emailEdit,phoneEdit,passwordEdit,confirmEdit;
    AutoCompleteTextView genderEdit;
    Button signup;
    TextView clickhere;
    DataBaseHelper DB;

    String[] genders={"Male","Female"};
    String NAME,EMAIL,PHONE,PASSWORD,CONFIRM,GENDER;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        ArrayAdapter<String> genderAdapter=new ArrayAdapter<String>(RegisterActivity.this,R.layout.items_list,genders);

        //name
        name=findViewById(R.id.name);
        nameEdit=findViewById(R.id.nameEdit);
        //email
        email=findViewById(R.id.email);
        emailEdit=findViewById(R.id.emailEdit);
        //phone
        phone=findViewById(R.id.phone);
        phoneEdit=findViewById(R.id.phoneEdit);
        //password
        password=findViewById(R.id.password);
        passwordEdit=findViewById(R.id.passwordEdit);
        //confirm
        confirm=findViewById(R.id.confirm);
        confirmEdit=findViewById(R.id.confirmEdit);
        //gender
        gender=findViewById(R.id.gender);
        genderEdit=findViewById(R.id.genderEdit);

        //Button
        signup=findViewById(R.id.signup);

        //go another
        clickhere=findViewById(R.id.clickhere);

        //attch with adapter
        genderEdit.setAdapter(genderAdapter);

        DB=new DataBaseHelper(this);

        codeForSignupButton();
        codeForClickHere();

    }

    public void codeForClickHere(){
        clickhere.setOnClickListener(view -> {
            Intent intent=new Intent(getApplicationContext(),MainActivity.class);
            startActivity(intent);
            finish();
        });
    }

    public void codeForSignupButton(){
        signup.setOnClickListener(view -> {
            //NAME,EMAIL,PHONE,PASSWORD,CONFIRM,GENDER
            NAME=nameEdit.getText().toString();
            EMAIL=emailEdit.getText().toString();
            PHONE=phoneEdit.getText().toString();
            PASSWORD=passwordEdit.getText().toString();
            CONFIRM=confirmEdit.getText().toString();
            GENDER=genderEdit.getText().toString();


            Boolean isValidated=validation(NAME,EMAIL,PHONE,PASSWORD,CONFIRM,GENDER);
            if(isValidated && !NAME.isEmpty() && !EMAIL.isEmpty() && !PHONE.isEmpty() && !PASSWORD.isEmpty() && !CONFIRM.isEmpty() && !GENDER.isEmpty()){
                //check user is already exist or not
                Boolean checkUser=DB.checkUserName(NAME);
                if(checkUser==false){
                    //insert user's data to database
                    Boolean insertUser=DB.insertData(NAME,EMAIL,PHONE,PASSWORD,GENDER);
                    if(insertUser==true){
                        Toast.makeText(RegisterActivity.this,"SignUp Successfully",Toast.LENGTH_SHORT).show();
                        Intent intent=new Intent(getApplicationContext(),HomeActivity.class);
                        startActivity(intent);
                        finish();
                    }else{
                        Toast.makeText(RegisterActivity.this,"SignUp Failed",Toast.LENGTH_SHORT).show();
                    }
                }else{
                    Toast.makeText(RegisterActivity.this,"User is Already Existed,Signup Again",Toast.LENGTH_SHORT).show();
                }


            }else{
                Toast.makeText(RegisterActivity.this,"Signup Failed",Toast.LENGTH_LONG).show();
            }





        });



        //for name
        nameEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                NAME=nameEdit.getText().toString();
                if(!NAME.matches("^[a-zA-z ]*$")){
                    name.setError("Name must be only character");
                }else{
                    name.setError(null);
                }

            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });
        //for email
        emailEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                EMAIL=emailEdit.getText().toString();
                if(!EMAIL.matches("[A-Z0-9a-z._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}")){
                    email.setError("Please Enter the valid email address");
                }else{
                    email.setError(null);
                }

            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });
        //for phone
        phoneEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                PHONE=phoneEdit.getText().toString();
                if(!PHONE.matches("^[0-9]{0,15}$")){
                    phone.setError("Phone number must be only number");
                }else{
                    phone.setError(null);
                }

            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });
        //for password
        passwordEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                PASSWORD=passwordEdit.getText().toString();
                if(!PASSWORD.matches("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#&()–[{}]:;',?/*~$^+=<>]).{8,20}$")){
                    password.setError("Password is too weak,set strong password");
                }else{
                    password.setError(null);
                }

            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });
        //for confirm
        confirmEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                CONFIRM=confirmEdit.getText().toString();
                PASSWORD=passwordEdit.getText().toString();
                if(!CONFIRM.matches(PASSWORD)){
                    confirm.setError("Password doesn't match");
                }else{
                    confirm.setError(null);
                }

            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });
        //for gender
        genderEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                gender.setError(null);
            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });



    }
    //NAME,EMAIL,PHONE,PASSWORD,CONFIRM,GENDER
    public Boolean validation(String NAME,String EMAIL,String PHONE,String PASSWORD,String CONFIRM,String GENDER){
        Boolean name=checkName(NAME);
        Boolean email=checkEmail(EMAIL);
        Boolean phone=checkPhone(PHONE);
        Boolean password=checkPassword(PASSWORD);
        Boolean confirm=checkConfirm(CONFIRM);
        Boolean gender=checkGender(GENDER);



        if(name && email && phone && password && confirm && gender){
            return true;
        }
        else{
            return false;
        }

    }

    public Boolean checkName(String NAME){
        if(NAME.equals("")){
            name.setError("Please fill the name");
            return false;
        }else{
            name.setError(null);
            return true;
        }
    }
    public Boolean checkEmail(String EMAIL){
        if(EMAIL.equals("")){
            email.setError("Please fill the email");
            return false;
        }else{
            email.setError(null);
            return true;
        }
    }
    public Boolean checkPhone(String PHONE){
        if(PHONE.equals("")){
            phone.setError("Please fill the phone number");
            return false;
        }else{
            phone.setError(null);
            return true;
        }
    }
    public Boolean checkPassword(String PASSWORD){
        if(PASSWORD.equals("")){
            password.setError("Please fill the password");
            return false;
        }else{
            password.setError(null);
            return true;
        }
    }
    public Boolean checkConfirm(String CONFIRM){
        if(CONFIRM.equals("")){
            confirm.setError("Please fill the confirm password");
            return false;
        }else{
            confirm.setError(null);
            return true;
        }
    }
    public Boolean checkGender(String GENDER){
        if(GENDER.equals("")){
            gender.setError("Please select the gender");
            return false;
        }else{
            gender.setError(null);
            return true;
        }

    }








}