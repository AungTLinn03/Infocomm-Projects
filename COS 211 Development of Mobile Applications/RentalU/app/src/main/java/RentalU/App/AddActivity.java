package RentalU.App;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.Toast;

import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;

public class AddActivity extends AppCompatActivity {
    TextInputLayout RNum,DTime,Price,PType,BType,FType,RName,Remark;
    TextInputEditText RNumEdit,DTimeEdit,PriceEdit,RNameEdit;
    AutoCompleteTextView PTypeEdit,BTypeEdit,FTypeEdit,RemarkEdit;
    Button confirm,view;
    DataBaseHelper DB;


    String[] property={"Barn","Apartment","Bungalow","Cabin","Condominium","Courtyard","Farmhouse","Manor"};
    String[] bedroom={"Master Bedrooms","Guest Bedrooms","Teen Bedrooms","Dorn Bedrooms","Kids Bedrooms"};
    String[] furniture={"Chaise,Media cabinet,Room divider","Table,TV stand,Wing chair,Love seats","Sofa,End Table,Carpet","Floor Lamp,Desk,BookCase","Washing Machine,Fridge,Microwave oven"};
    String[] remark={"Low","Normal","Good","Excellent"};
    String refNumber,dateTime,price,propertyType,bedrooms,furnitureType,reporterName,remarks;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add);


        ArrayAdapter<String> propertyAdapter=new ArrayAdapter<String>(AddActivity.this,R.layout.items_list,property);
        ArrayAdapter<String> bedroomAdapter=new ArrayAdapter<String>(AddActivity.this,R.layout.items_list,bedroom);
        ArrayAdapter<String> furnitureAdapter=new ArrayAdapter<String>(AddActivity.this,R.layout.items_list,furniture);
        ArrayAdapter<String> remarkAdapter=new ArrayAdapter<String>(AddActivity.this,R.layout.items_list,remark);



        //reference number
        RNum=findViewById(R.id.RNum);
        RNumEdit=findViewById(R.id.RNumEdit);
        //DateTime
        DTime=findViewById(R.id.DTime_Update);
        DTimeEdit=findViewById(R.id.DTimeEdit_Update);
        //Rent Price
        Price=findViewById(R.id.Price_Update);
        PriceEdit=findViewById(R.id.PriceEdit_Update);
        //Property Type
        PType=findViewById(R.id.PType_Update);
        PTypeEdit=findViewById(R.id.PTypeEdit_Update);
        //Bedrooms
        BType=findViewById(R.id.BType_Update);
        BTypeEdit=findViewById(R.id.BTypeEdit_Update);
        //Furniture Type
        FType=findViewById(R.id.FType_Update);
        FTypeEdit=findViewById(R.id.FTypeEdit_Update);
        //Reporter Name
        RName=findViewById(R.id.RName_Update);
        RNameEdit=findViewById(R.id.RNameEdit_Update);
        //Remark
        Remark=findViewById(R.id.Remark_Update);
        RemarkEdit=findViewById(R.id.RemarkEdit_Update);

        //Button
        confirm=findViewById(R.id.update_one);
        view=findViewById(R.id.view_one);

        //attach with adapter
        PTypeEdit.setAdapter(propertyAdapter);
        BTypeEdit.setAdapter(bedroomAdapter);
        FTypeEdit.setAdapter(furnitureAdapter);
        RemarkEdit.setAdapter(remarkAdapter);

        DB=new DataBaseHelper(this);


        //invoking the methods
        codeForAllButton();



    }

    public void codeForAllButton(){

        confirm.setOnClickListener(view -> {
            refNumber=RNumEdit.getText().toString();
            dateTime=DTimeEdit.getText().toString();
            price=PriceEdit.getText().toString();
            propertyType=PTypeEdit.getText().toString();
            bedrooms=BTypeEdit.getText().toString();
            furnitureType=FTypeEdit.getText().toString();
            reporterName=RNameEdit.getText().toString();
            remarks=RemarkEdit.getText().toString();

            Boolean isValidated=validation(refNumber,dateTime,price,propertyType,bedrooms,furnitureType,reporterName,remarks);
            if(isValidated && !refNumber.isEmpty() && !dateTime.isEmpty() && !price.isEmpty() && !propertyType.isEmpty() && !bedrooms.isEmpty() && !furnitureType.isEmpty() && !reporterName.isEmpty() && !remarks.isEmpty()){
                Boolean isInserted=DB.insertRentalData(refNumber,dateTime,price,propertyType,bedrooms,furnitureType,reporterName,remarks);

                if(isInserted==true){
                    Toast.makeText(AddActivity.this,"Data is inserted",Toast.LENGTH_LONG).show();
                    cleardata();
                }else{
                    Toast.makeText(AddActivity.this,"Data is not inserted",Toast.LENGTH_LONG).show();
                }
            }

        });

        view.setOnClickListener(view -> {
            Intent intent=new Intent(getApplicationContext(),ViewActivity.class);
            startActivity(intent);
        });


        RNumEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                refNumber=RNumEdit.getText().toString();
                if(!refNumber.matches("^[0-9]{0,15}$")){
                    RNum.setError("Reference Number must be only number");
                }else{
                    RNum.setError(null);
                }

            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });


        DTimeEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                dateTime=DTimeEdit.getText().toString();
                if(!dateTime.matches("[0-9.: A-Za-z]*$")){
                    DTime.setError("DateTime Format must be like (25.4.2022 9:30AM)");
                }else{
                    DTime.setError(null);
                }
            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });

        PriceEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                price=PriceEdit.getText().toString();
                if(!price.matches("[0-9./*]{0,15}$")){
                    Price.setError("Price must be only number");
                }else{
                    Price.setError(null);
                }
            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });


        RNameEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                reporterName=RNameEdit.getText().toString();
                if(!reporterName.matches("^[a-zA-z ]*$")){
                    RName.setError("Name must be only character");
                }else{
                    RName.setError(null);
                }
            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });

        PTypeEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                PType.setError(null);
            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });

        BTypeEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                BType.setError(null);
            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });

        FTypeEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                FType.setError(null);
            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });

        RemarkEdit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {}
            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {
                Remark.setError(null);
            }
            @Override
            public void afterTextChanged(Editable editable) {}
        });



    }

    public void cleardata(){
        RNumEdit.setText("");
        DTimeEdit.setText("");
        PriceEdit.setText("");
        PTypeEdit.setText("");
        BTypeEdit.setText("");
        FTypeEdit.setText("");
        RNameEdit.setText("");
        RemarkEdit.setText("");
    }


    public Boolean validation(String refNumber,String dateTime,String price,String propertyType,String bedroom,String furnitureType,String reporterName,String remark){
             Boolean fNum=vrefNumber(refNumber);
             Boolean fdateTime=vdateTime(dateTime);
             Boolean fPrice=vprice(price);
             Boolean fProperty=vproperty(propertyType);
             Boolean fbedroom=vbedroom(bedroom);
             Boolean fFurniture=vfurniture(furnitureType);
             Boolean frptName=vrname(reporterName);
             Boolean fremark=vremark(remark);


        if(fNum && fdateTime && fPrice && fProperty && fbedroom && fFurniture && frptName &&fremark){
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

    public Boolean vdateTime(String dateTime){
        if(dateTime.equals("")){
            DTime.setError("Please Fill The Date and Time");
            return false;
        }else{
            DTime.setError(null);
            return true;
        }
    }



    public Boolean vprice(String price){
        if(price.equals("")){
            Price.setError("Please Fill The Price");
            return false;
        } else{
            Price.setError(null);
            return true;
        }
    }

    public Boolean vproperty(String propertyType){
        if(propertyType.equals("")){
            PType.setError("Please select the property type");
            return false;
        }else{
            PType.setError(null);
            return true;
        }
    }


    public Boolean vbedroom(String bedroom){
        if(bedroom.equals("")){
            BType.setError("Please select the bedroom type");
            return false;
        }else{
            BType.setError(null);
            return true;
        }
    }

    public Boolean vfurniture(String furnitureType){
        if(furnitureType.equals("")){
            FType.setError("Please select the furniture type");
            return false;
        }else{
            FType.setError(null);
            return true;
        }
    }


    public Boolean vrname(String reporterName){
        if(reporterName.equals("")){
            RName.setError("Please enter the reporter name");
            return false;
        }else{
            RName.setError(null);
            return true;
        }
    }

    public Boolean vremark(String remark){
        if(remark.equals("")){
            Remark.setError("Please select the remark");
            return false;
        }else{
            Remark.setError("");
            return true;
        }
    }


}
























