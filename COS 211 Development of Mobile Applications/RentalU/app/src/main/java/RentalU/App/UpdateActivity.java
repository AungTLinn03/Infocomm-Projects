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
import android.widget.Toast;

import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;

import java.util.ArrayList;

public class UpdateActivity extends AppCompatActivity {
    TextInputLayout DTime,Price,PType,BType,FType,RName,Remark;
    TextInputEditText DTimeEdit,PriceEdit,RNameEdit;
    AutoCompleteTextView PTypeEdit,BTypeEdit,FTypeEdit,RemarkEdit;
    Button update,view;
    DataBaseHelper DB;

    String[] property={"Barn","Apartment","Bungalow","Cabin","Condominium","Courtyard","Farmhouse","Manor"};
    String[] bedroom={"Master Bedrooms","Guest Bedrooms","Teen Bedrooms","Dorn Bedrooms","Kids Bedrooms"};
    String[] furniture={"Chaise,Media cabinet,Room divider","Table,TV stand,Wing chair,Love seats","Sofa,End Table,Carpet","Floor Lamp,Desk,BookCase","Washing Machine,Fridge,Microwave oven"};
    String[] remark={"Low","Normal","Good","Excellent"};
    String refNumber,dateTime,price,propertyType,bedrooms,furnitureType,reporterName,remarks;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update);

        ArrayAdapter<String> propertyAdapter=new ArrayAdapter<String>(UpdateActivity.this,R.layout.items_list,property);
        ArrayAdapter<String> bedroomAdapter=new ArrayAdapter<String>(UpdateActivity.this,R.layout.items_list,bedroom);
        ArrayAdapter<String> furnitureAdapter=new ArrayAdapter<String>(UpdateActivity.this,R.layout.items_list,furniture);
        ArrayAdapter<String> remarkAdapter=new ArrayAdapter<String>(UpdateActivity.this,R.layout.items_list,remark);

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
        update=findViewById(R.id.update_one);
        view=findViewById(R.id.view_one);
        Bundle bundle=getIntent().getExtras();

        ArrayList<String> rental_data_list=bundle.getStringArrayList("rental_data");
        refNumber=rental_data_list.get(0);
        DTime.getEditText().setText(rental_data_list.get(1));
        Price.getEditText().setText(rental_data_list.get(2));
        PType.getEditText().setText(rental_data_list.get(3));
        BType.getEditText().setText(rental_data_list.get(4));
        FType.getEditText().setText(rental_data_list.get(5));
        RName.getEditText().setText(rental_data_list.get(6));
        Remark.getEditText().setText(rental_data_list.get(7));

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


        update.setOnClickListener(view -> {
            dateTime=DTimeEdit.getText().toString();
            price=PriceEdit.getText().toString();
            propertyType=PTypeEdit.getText().toString();
            bedrooms=BTypeEdit.getText().toString();
            furnitureType=FTypeEdit.getText().toString();
            reporterName=RNameEdit.getText().toString();
            remarks=RemarkEdit.getText().toString();

            Boolean isValidated=validation(dateTime,price,propertyType,bedrooms,furnitureType,reporterName,remarks);
            if(isValidated && !dateTime.isEmpty() && !price.isEmpty() && !propertyType.isEmpty() && !bedrooms.isEmpty() && !furnitureType.isEmpty() && !reporterName.isEmpty() && !remarks.isEmpty()){
                //change this line
                Boolean isUpdated=DB.updateRentalData(refNumber,dateTime,price,propertyType,bedrooms,furnitureType,reporterName,remarks);

                if(isUpdated==true){
                    Toast.makeText(UpdateActivity.this,"Data is updated",Toast.LENGTH_LONG).show();
                    cleardata();
                }else{
                    Toast.makeText(UpdateActivity.this,"Data is not updated",Toast.LENGTH_LONG).show();
                }
            }
        });

        view.setOnClickListener(view1 -> {
            Intent intent=new Intent(getApplicationContext(),ViewActivity.class);
            startActivity(intent);
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
        DTimeEdit.setText("");
        PriceEdit.setText("");
        PTypeEdit.setText("");
        BTypeEdit.setText("");
        FTypeEdit.setText("");
        RNameEdit.setText("");
        RemarkEdit.setText("");
    }


    public Boolean validation(String dateTime,String price,String propertyType,String bedroom,String furnitureType,String reporterName,String remark){
        Boolean fdateTime=vdateTime(dateTime);
        Boolean fPrice=vprice(price);
        Boolean fProperty=vproperty(propertyType);
        Boolean fbedroom=vbedroom(bedroom);
        Boolean fFurniture=vfurniture(furnitureType);
        Boolean frptName=vrname(reporterName);
        Boolean fremark=vremark(remark);


        if(fdateTime && fPrice && fProperty && fbedroom && fFurniture && frptName &&fremark){
            return true;
        }
        else{
            return false;
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