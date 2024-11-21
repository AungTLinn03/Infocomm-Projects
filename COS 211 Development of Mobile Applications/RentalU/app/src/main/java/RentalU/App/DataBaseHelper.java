package RentalU.App;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.widget.Toast;

import androidx.annotation.Nullable;

public class DataBaseHelper extends SQLiteOpenHelper {
    private static final String DBNAME="rental.db";

    public DataBaseHelper(@Nullable Context context) {
        super(context,"rental.db",null,1);
    }

    @Override
    public void onCreate(SQLiteDatabase MyDB) {
        MyDB.execSQL("create table users(id integer primary key autoincrement,username text,email text,phone text,password text,gender text)");
        MyDB.execSQL("create table rentaldata(id integer primary key autoincrement,reference_number text,date_time text,price text,property_type text,bedroom_type text,furniture_type text,reporter_name text,remark text)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase MyDB, int i, int i1) {
        MyDB.execSQL("drop table if exists users");
        MyDB.execSQL("drop table if exists rentaldata");
    }

    //insert data to DB from signup form
    public Boolean insertData(String username,String email,String phone,String password,String gender){
        SQLiteDatabase MyDB=this.getWritableDatabase();
        ContentValues contentValues=new ContentValues();
        contentValues.put("username",username);
        contentValues.put("email",email);
        contentValues.put("phone",phone);
        contentValues.put("password",password);
        contentValues.put("gender",gender);
        long result=MyDB.insert("users",null,contentValues);
        if(result==-1){
            return false;
        }else{
            return true;
        }

    }

    //insert data to DB from data adding form
    public Boolean insertRentalData(String rnum,String dtime,String price,String ptype,String btype,String ftype,String rname,String remark){
        SQLiteDatabase MyDB=this.getWritableDatabase();
        ContentValues contentValues=new ContentValues();
        contentValues.put("reference_number",rnum);
        contentValues.put("date_time",dtime);
        contentValues.put("price",price);
        contentValues.put("property_type",ptype);
        contentValues.put("bedroom_type",btype);
        contentValues.put("furniture_type",ftype);
        contentValues.put("reporter_name",rname);
        contentValues.put("remark",remark);

        long result=MyDB.insert("rentaldata",null,contentValues);
        if(result==-1){
            return false;
        }else{
            return true;
        }

    }



    //update the data from rentalData table
    public Boolean updateRentalData(String rnum,String dtime,String price,String ptype,String btype,String ftype,String rname,String remark){
        SQLiteDatabase MyDB=this.getWritableDatabase();
        ContentValues contentValues=new ContentValues();
        contentValues.put("reference_number",rnum);
        contentValues.put("date_time",dtime);
        contentValues.put("price",price);
        contentValues.put("property_type",ptype);
        contentValues.put("bedroom_type",btype);
        contentValues.put("furniture_type",ftype);
        contentValues.put("reporter_name",rname);
        contentValues.put("remark",remark);

       MyDB.update("rentaldata",contentValues,"reference_number=?",new String[]{rnum});
        return true;
    }

    //delete the data from rentalData table
    public Boolean deleteRentalData(String rnum){
        SQLiteDatabase sqLiteDatabase=this.getWritableDatabase();
        long result=sqLiteDatabase.delete("rentaldata","reference_number=?",new String[]{rnum});
        if(result!=0){
            return true;
        }else{
            return false;
        }
    }


    //get the data from rentaldata table
    public Cursor getdata(){
        SQLiteDatabase MyDB=this.getWritableDatabase();
        Cursor cursor=MyDB.rawQuery("select* from rentaldata",null);
        return cursor;
    }

    //get the data from rental table with the reference number
    public Cursor getdata_ref(String ref_number){
        SQLiteDatabase MyDB=this.getWritableDatabase();
        Cursor cursor=MyDB.rawQuery("select* from rentaldata where reference_number=?",new String[]{ref_number});
        return cursor;
    }



    //check the user from signup form if already exist or not in DB by validating with only username.
    //if already exist, signup again
    public Boolean checkUserName(String username){
        SQLiteDatabase MyDB=this.getWritableDatabase();
        Cursor cursor=MyDB.rawQuery("select * from users where username=?",new String[]{username});
        if(cursor.getCount()>0){
            return true;
        }else{
            return false;
        }

    }

    //check the user from login form if already exist or not in DB by validating with username and password
    //if already exist, allow to login
    public Boolean checkUserNamePassword(String username,String password){
        SQLiteDatabase MyDB=this.getWritableDatabase();
        Cursor cursor=MyDB.rawQuery("select * from users where username=? and password=?",new String[]{username,password});
        if(cursor.getCount()>0){
            return true;
        }
        else{
            return false;
        }
    }


    public Integer clearData(){
        SQLiteDatabase MyDB=this.getWritableDatabase();
        return MyDB.delete("users",null,null);
    }
}

