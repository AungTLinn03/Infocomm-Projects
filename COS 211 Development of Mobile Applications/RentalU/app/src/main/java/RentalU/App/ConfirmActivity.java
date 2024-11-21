package RentalU.App;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.widget.Button;
import android.widget.Toast;

import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;

import java.util.ArrayList;

public class ConfirmActivity extends AppCompatActivity {
    TextInputLayout RNum;
    TextInputEditText RNumEdit;
    Button confirm;
    DataBaseHelper DB;
    String rnum;
    ArrayList<String> data_list=new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_confirm);
        RNum=findViewById(R.id.RNum_Confirm);
        RNumEdit=findViewById(R.id.RNumEdit_Confirm);
        confirm=findViewById(R.id.confirm_update);
        DB=new DataBaseHelper(this);
        codeForConfirmButton();
    }

    private void goToUpdateActivity(){

        Intent i=new Intent(this,UpdateActivity.class);
        i.putExtra("rental_data",data_list);
        startActivity(i);
        RNum.getEditText().setText("");
    }

    public void codeForConfirmButton(){
        confirm.setOnClickListener(view -> {
            rnum =RNumEdit.getText().toString();
            Boolean isValidated=validation(rnum);

            if(isValidated && !rnum.isEmpty()){

                Cursor cursor=DB.getdata_ref(rnum);
                if(cursor.getCount()==0){
                    Toast.makeText(ConfirmActivity.this,"No Such References Found",Toast.LENGTH_LONG).show();
                }
                else{
                    while (cursor.moveToNext()){
                        data_list.add(cursor.getString(1));
                        data_list.add(cursor.getString(2));
                        data_list.add(cursor.getString(3));
                        data_list.add(cursor.getString(4));
                        data_list.add(cursor.getString(5));
                        data_list.add(cursor.getString(6));
                        data_list.add(cursor.getString(7));
                        data_list.add(cursor.getString(8));
                    }

                    goToUpdateActivity();

                }

            }

        });



        RNumEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                rnum=RNumEdit.getText().toString();
                if(!rnum.matches("^[0-9]{0,15}$")){
                    RNum.setError("Reference Number must be only number");
                }else{
                    RNum.setError(null);
                }

            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });


    }

    public Boolean validation(String refNumber){
        Boolean fNum=vrefNumber(refNumber);

        if(fNum){
            return true;
        }
        else{
            return false;
        }

    }

    public Boolean vrefNumber(String refNumber){
        if(refNumber.equals("")){
            RNum.setError("Please Fill The Reference Number");
            return false;
        }else{
            RNum.setError(null);
            return true;
        }
    }








}