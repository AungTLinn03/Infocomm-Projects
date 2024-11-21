package RentalU.App;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.widget.Button;
import android.widget.Toast;

import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;

public class DeleteActivity extends AppCompatActivity {
    TextInputLayout RNum;
    TextInputEditText RNumEdit;
    Button delete,view;
    DataBaseHelper DB;
    String rnum;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_delete);

        RNum=findViewById(R.id.RNum_Confirm);
        RNumEdit=findViewById(R.id.RNumEdit_Confirm);
        delete=findViewById(R.id.confirm_update);
        view=findViewById(R.id.view);
        DB=new DataBaseHelper(this);

        codeForDeleteButton();
        codeForViewButton();

    }

    public void codeForDeleteButton(){
        delete.setOnClickListener(view1 -> {
           rnum =RNumEdit.getText().toString();

            Boolean isValidated=validation(rnum);
            if(isValidated && !rnum.isEmpty()){

                //change this line
                Boolean isInserted=DB.deleteRentalData(rnum);

                if(isInserted==true){
                    Toast.makeText(DeleteActivity.this,"Data is deleted",Toast.LENGTH_LONG).show();
                    RNumEdit.setText("");
                }else{
                    Toast.makeText(DeleteActivity.this,"Data is not deleted",Toast.LENGTH_LONG).show();
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



    public void codeForViewButton(){
        view.setOnClickListener(view1 -> {
            Intent intent=new Intent(getApplicationContext(),ViewActivity.class);
            startActivity(intent);
        });
    }

}