package RentalU.App;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.database.Cursor;
import android.os.Bundle;
import android.widget.Toast;

import java.util.ArrayList;

public class ViewActivity extends AppCompatActivity {
    RecyclerView recyclerView;
    ArrayList<String> refNumber,dateTime,price,propertyType,bedrooms,furnitureType,reporterName,remarks;
    DataBaseHelper DB;
    MyAdapter adapter;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view);
        DB=new DataBaseHelper(this);
        refNumber=new ArrayList<>();
        dateTime=new ArrayList<>();
        price=new ArrayList<>();
        propertyType=new ArrayList<>();
        bedrooms=new ArrayList<>();
        furnitureType=new ArrayList<>();
        reporterName=new ArrayList<>();
        remarks=new ArrayList<>();
        recyclerView=findViewById(R.id.recyclerview);
        adapter=new MyAdapter(this,refNumber,dateTime,price,propertyType,bedrooms,furnitureType,reporterName,remarks);
        recyclerView.setAdapter(adapter);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        displayData();

    }

    private void displayData(){
        Cursor cursor=DB.getdata();
        if(cursor.getCount()==0){
            Toast.makeText(ViewActivity.this,"No Entry Found",Toast.LENGTH_LONG).show();
        }
        else{
            while (cursor.moveToNext()){
                refNumber.add(cursor.getString(1));
                dateTime.add(cursor.getString(2));
                price.add(cursor.getString(3));
                propertyType.add(cursor.getString(4));
                bedrooms.add(cursor.getString(5));
                furnitureType.add(cursor.getString(6));
                reporterName.add(cursor.getString(7));
                remarks.add(cursor.getString(8));
            }
        }
    }
}