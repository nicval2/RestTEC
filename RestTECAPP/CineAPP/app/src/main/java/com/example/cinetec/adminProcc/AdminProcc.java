package com.example.cinetec.adminProcc;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.cinetec.R;
import com.example.cinetec.adminView;
import com.example.cinetec.confirmView;

public class AdminProcc extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin_procc);
    }

    public void onClickRegister(View view) {
        Intent intent = new Intent(this, registerProcc.class);
        startActivity(intent);
    }

    public void onClickEdit(View view) {
        Intent intent = new Intent(this, editProcc.class);
        startActivity(intent);
    }

    public void onClickDelete(View view) {
        Intent intent = new Intent(this, deleteProcc.class);
        startActivity(intent);
    }

    public void onClickConsult(View view) {
        Intent intent = new Intent(this, consultProcc.class);
        startActivity(intent);
    }

    public void onClickBack(View view) {
        Intent intent = new Intent(this, adminView.class);
        startActivity(intent);
    }
}