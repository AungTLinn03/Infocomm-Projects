package RentalU.App;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;

public class HomeActivity extends AppCompatActivity {
    Button view,add,update,delete;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);
        view=findViewById(R.id.btnView);
        add=findViewById(R.id.btnAdd);
        update=findViewById(R.id.btnUpdate);
        delete=findViewById(R.id.btnDelete);

        codeForAddButton();
        codeForViewButton();
        codeForUpdateButton();
        codeForDeleteButton();
    }
    public void codeForAddButton(){
        add.setOnClickListener(view1 -> {
            Intent intent=new Intent(getApplicationContext(),AddActivity.class);
            startActivity(intent);
        });

    }
    public void codeForViewButton(){
        view.setOnClickListener(view1 -> {
            Intent intent=new Intent(getApplicationContext(),ViewActivity.class);
            startActivity(intent);
        });

    }
    public void codeForUpdateButton(){
        update.setOnClickListener(view1 -> {
            Intent intent=new Intent(getApplicationContext(),ConfirmActivity.class);
            startActivity(intent);
        });
    }

    public void codeForDeleteButton(){
        delete.setOnClickListener(view1 -> {
            Intent intent=new Intent(getApplicationContext(),DeleteActivity.class);
            startActivity(intent);
        });
    }

}