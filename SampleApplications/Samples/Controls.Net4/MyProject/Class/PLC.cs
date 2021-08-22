using Opc.Ua.Client;

namespace Opc.Ua.Sample.Controls
{
    public class PLC
    {

        public Session m_session;
        private SessionReconnectHandler m_reconnectHandler;
        private int m_reconnectPeriod = 10;
        //private ApplicationInstance m_application;
        private Opc.Ua.Server.StandardServer m_server;
        private ConfiguredEndpointCollection m_endpoints;
        private ApplicationConfiguration m_configuration;
        private ServiceMessageContext m_context;

        public bool PLC_Connected = false;

        //Public class
        protected PLC()
        {

        }

        private static PLC _instance;
        public static PLC Instance()
        {
            if (_instance == null)
            {
                _instance = new PLC();
            }
            return _instance;
        }

        public bool IsConnected()
        {
            if (m_session != null)
            {
                PLC_Connected = true;
                return true;
            }
            else
            {
                PLC_Connected = false;
                return false;
            }
        }

        public string VariableRead(string node)
        {
            try
            {
                ReadValueIdCollection nodesToRead = new ReadValueIdCollection();
                ReadValueId valueId = new ReadValueId();
                valueId.NodeId = new NodeId(node);
                valueId.AttributeId = Attributes.Value;
                valueId.IndexRange = null;
                valueId.DataEncoding = null;
                nodesToRead.Add(valueId);

                if (nodesToRead == null || nodesToRead.Count == 0)
                {
                    return null;
                }

                DataValueCollection values = null;
                DiagnosticInfoCollection diagnosticInfos = null;

                ResponseHeader responseHeader = m_session.Read(
                    null,
                    0,
                    TimestampsToReturn.Both,
                    nodesToRead,
                    out values,
                    out diagnosticInfos);

                ClientBase.ValidateResponse(values, nodesToRead);
                ClientBase.ValidateDiagnosticInfos(diagnosticInfos, nodesToRead);

                string value = "";
                if (values[0].Value != null)
                {
                    var rawValue = values[0].WrappedValue.ToString();
                    value = rawValue.Replace("|", "\r\n").Replace("{", "").Replace("}", "");
                }
                return value;


            }
            catch
            {
                return null;
            }
        }

        public StatusCodeCollection VariableWrite(string nodeId, object value)
        {
            var nodeToWrite = new WriteValue()
            {
                NodeId = nodeId,
                AttributeId = Attributes.Value,
                Value = new DataValue()
                {
                    WrappedValue = new Variant(value)
                }
            };

            WriteValueCollection nodesToWrite = new WriteValueCollection() { nodeToWrite };

            ResponseHeader responseHeader = m_session.Write(
                null,
                nodesToWrite,
                out StatusCodeCollection results,
                out DiagnosticInfoCollection diagnosticInfos);

            ClientBase.ValidateResponse(results, nodesToWrite);
            ClientBase.ValidateDiagnosticInfos(diagnosticInfos, nodesToWrite);

            return results;
        }
    }
}
