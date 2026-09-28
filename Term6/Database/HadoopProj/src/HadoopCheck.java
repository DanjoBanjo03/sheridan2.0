import org.apache.hadoop.util.VersionInfo;

public class HadoopCheck {
    public static void main(String[] args) {
        System.out.println("Hadoop: " + VersionInfo.getVersion());
        System.out.println("Java: " + System.getProperty("java.version"));
    }
}