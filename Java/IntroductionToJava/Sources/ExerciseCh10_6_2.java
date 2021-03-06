import java.lang.reflect.*;
import java.lang.annotation.*;
@Retention(RetentionPolicy.RUNTIME)
@interface Message{
    String msg() default "[empty]";
}
@Message(msg = "Sample Class")
class SampleClass {
    @Message(msg = "int value1")
    public int value1;
    @Message(msg = "int value2")
    public int value2;
}
public class ExerciseCh10_6_2 {
    public static void main(String[] args){
        SampleClass test = new SampleClass();
        Class<? extends  SampleClass> c = test.getClass();
        for(Field f : c.getDeclaredFields()){
            if(f.isAnnotationPresent(Message.class)){
                System.out.println(f.getName() + " has annotation.");
                for(Annotation a : f.getAnnotations())
                    System.out.println(a.toString());

            }
            else
                System.out.println(f.getName() + " has not annotation.");
        }

    }
}
