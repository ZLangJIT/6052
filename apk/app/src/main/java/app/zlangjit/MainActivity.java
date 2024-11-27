package app.zlangjit;

import android.os.Bundle;
import android.view.View;

import com.google.androidgamesdk.GameActivity;

public class MainActivity extends GameActivity {
    static {
        System.loadLibrary("emu_main_jni");
    }
    
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        IRCService.createNotificationChannel(this);
        IRCService.start(this);
    }

    public boolean requestExit() {
        IRCService.stop(this);
        return true;
    }
    
    boolean saved_vis = false;
    int vis_original = 0;
    int vis_immersive = 0;

    @Override
    public void onWindowFocusChanged(boolean hasFocus) {
        super.onWindowFocusChanged(hasFocus);

        if (hasFocus) {
            //hideSystemUi();
        }
    }

    private void hideSystemUi() {
        View decorView = getWindow().getDecorView();
        if (!saved_vis) {
            vis_original = decorView.getSystemUiVisibility();
            vis_immersive = View.SYSTEM_UI_FLAG_IMMERSIVE_STICKY
                    | View.SYSTEM_UI_FLAG_LAYOUT_STABLE
                    | View.SYSTEM_UI_FLAG_LAYOUT_HIDE_NAVIGATION
                    | View.SYSTEM_UI_FLAG_LAYOUT_FULLSCREEN
                    | View.SYSTEM_UI_FLAG_HIDE_NAVIGATION
                    | View.SYSTEM_UI_FLAG_FULLSCREEN;
            saved_vis = true;
        }
        decorView.setSystemUiVisibility(vis_immersive);
    }
}
