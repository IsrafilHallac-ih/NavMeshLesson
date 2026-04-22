using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform player;
    NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // SetDestination ajanýn hedefini belirle
        agent.SetDestination(player.position);
    }



    private void Start()
    {

      //--------NavMesh Agent Ayarlarý-----

        //Agent Type:Ajan tipi burdan ayarlanýr.
        //Base Offset:Bu nesnemizin pivot noktasý ilezemin arasýndaki uzaklýðý belirleyen ayardýr genellikle 0.5 dir.
        //Angular Speed:AJANIN ne kadar hýzlý döneceðini gösterir
        //Acceleration:Ajanýn ne kadar hýzlý ivmelenip duracaðýný ayarlar.
        //Stopping distance:AJanýn hedefe yaklaþýrken kaç birim ötede duracagýný gösterir.
        //Auto Braking:Otomatik stoplama sistemi.
        // NavMesh Modifier özelligi navmeshýn uzerindeki etkisini degistirmeye yarýyor.
        //NavMesh Obstacle:carve ayarý oyuk açma ayarýdýr.Engel koymak icin kullanýlýr

        
    }
}
