package springweb.utils;

import org.springframework.format.annotation.DateTimeFormat;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.logging.SimpleFormatter;

/**
 * Created by MinhPK on 7/30/15.
 */
public class DateTimeUtils {
    public static String date2string(Date date) {
        SimpleDateFormat format = new SimpleDateFormat(Constants.DATE_FORMAT);
        return format.format(date).toString();
    }
}
