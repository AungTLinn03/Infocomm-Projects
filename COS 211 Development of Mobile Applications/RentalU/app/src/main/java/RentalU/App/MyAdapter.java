package RentalU.App;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class MyAdapter extends RecyclerView.Adapter<MyAdapter.MyViewHolder> {
    private Context context;
    private ArrayList rnum_id,dtime_id,price_id,ptype_id,btype_id,ftype_id,rname_id,remark_id;

    public MyAdapter(Context context, ArrayList rnum_id, ArrayList dtime_id, ArrayList price_id, ArrayList ptype_id, ArrayList btype_id, ArrayList ftype_id, ArrayList rname_id, ArrayList remark_id) {
        this.context = context;
        this.rnum_id = rnum_id;
        this.dtime_id = dtime_id;
        this.price_id = price_id;
        this.ptype_id = ptype_id;
        this.btype_id = btype_id;
        this.ftype_id = ftype_id;
        this.rname_id = rname_id;
        this.remark_id = remark_id;
    }

    @NonNull
    @Override
    public MyViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v= LayoutInflater.from(context).inflate(R.layout.dataentry,parent,false);
        return new MyViewHolder(v);
    }

    @Override
    public void onBindViewHolder(@NonNull MyViewHolder holder, int position) {
            holder.rnum_id.setText(String.valueOf(rnum_id.get(position)));
            holder.dtime_id.setText(String.valueOf(dtime_id.get(position)));
            holder.price_id.setText(String.valueOf(price_id.get(position)));
            holder.ptype_id.setText(String.valueOf(ptype_id.get(position)));
            holder.btype_id.setText(String.valueOf(btype_id.get(position)));
            holder.ftype_id.setText(String.valueOf(ftype_id.get(position)));
            holder.rname_id.setText(String.valueOf(rname_id.get(position)));
            holder.remark_id.setText(String.valueOf(remark_id.get(position)));
    }

    @Override
    public int getItemCount() {
        return rnum_id.size();
    }

    public class MyViewHolder extends RecyclerView.ViewHolder {
        TextView rnum_id,dtime_id,price_id,ptype_id,btype_id,ftype_id,rname_id,remark_id;
        public MyViewHolder(@NonNull View itemView) {
            super(itemView);
            rnum_id=itemView.findViewById(R.id.textReferenceNum);
            dtime_id=itemView.findViewById(R.id.textDTime);
            price_id=itemView.findViewById(R.id.textPrice);
            ptype_id=itemView.findViewById(R.id.textPtype);
            btype_id=itemView.findViewById(R.id.textBtype);
            ftype_id=itemView.findViewById(R.id.textFtype);
            rname_id=itemView.findViewById(R.id.textRName);
            remark_id=itemView.findViewById(R.id.textRemark);

        }
    }
}
