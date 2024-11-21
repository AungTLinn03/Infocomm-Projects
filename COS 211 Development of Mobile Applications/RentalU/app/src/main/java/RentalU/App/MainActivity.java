package RentalU.App;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;

import java.util.concurrent.atomic.AtomicInteger;

public class MainActivity extends AppCompatActivity {
    TextInputLayout name,password;
    TextInputEditText nameEdit,passwordEdit;
    Button login;
    TextView clickhere;
    DataBaseHelper DB;
    String NAME,PASSWORD;
    int i=5;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //name
        name=findViewById(R.id.name);
        nameEdit=findViewById(R.id.nameEdit);

        //password
        password=findViewById(R.id.password);
        passwordEdit=findViewById(R.id.passwordEdit);

        //Button
        login=findViewById(R.id.login);

        DB=new DataBaseHelper(this);

        //go another
        clickhere=findViewById(R.id.clickhere);

        codeForLoginButton();
        codeForClickHere();

    }


    public void codeForLoginButton(){


            login.setOnClickListener(view -> {
                if(i!=0){

                    NAME=nameEdit.getText().toString();
                    PASSWORD=passwordEdit.getText().toString();

                    Boolean isValidated=validation(NAME,PASSWORD);

                    if(isValidated && !NAME.isEmpty() && !PASSWORD.isEmpty()){
                        //check user is already exist or not
                        Boolean checkUserNamePassword=DB.checkUserNamePassword(NAME,PASSWORD);
                        if(checkUserNamePassword){
                            Toast.makeText(MainActivity.this,"Login Successfully",Toast.LENGTH_SHORT).show();
                            Intent intent=new Intent(getApplicationContext(),HomeActivity.class);
                            startActivity(intent);
                            finish();
                        }else{
                            Toast.makeText(MainActivity.this,"Invalid Credentials",Toast.LENGTH_SHORT).show();
                            i=i-1;
                        }
                    }

                }
                else{
                    login.setEnabled(false);
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
                    name.setError("Name must be only Character");
                }else{
                    name.setError(null);
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



    }


    public Boolean validation(String NAME,String PASSWORD){
        Boolean name=checkName(NAME);
        Boolean password=checkPassword(PASSWORD);


        if(name  && password){
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

    public Boolean checkPassword(String PASSWORD){
        if(PASSWORD.equals("")){
            password.setError("Please fill the password");
            return false;
        }else{
            password.setError(null);
            return true;
        }
    }







    public void codeForClickHere(){
        clickhere.setOnClickListener(view -> {
            Intent intent=new Intent(getApplicationContext(),RegisterActivity.class);
            startActivity(intent);
            finish();
        });
    }



}