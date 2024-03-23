package com.example.cinetec.adminSucursal;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import com.example.cinetec.R;
import com.example.cinetec.confirmView;

public class deleteSucursal extends AppCompatActivity {
    EditText Iname;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_delete_sucursal);
        Iname = (EditText) findViewById(R.id.Iname);
    }

    public void OnClickRegister(View view) {
        String Name1 = Iname.getText().toString();
        if (Name1.isEmpty()){
            Iname.setError("Este campo no puede estar vacio");
            return;
        }
        Intent intent = new Intent(this, confirmView.class);
        startActivity(intent);
    }

    public void onClickBack(View view) {
        Intent intent = new Intent(this, AdminSucursal.class);
        startActivity(intent);
    }
}