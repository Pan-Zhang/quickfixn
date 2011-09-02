// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class TradingSessionStatus : Message
        {
            public const string MsgType = "h";

            public TradingSessionStatus() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("h"));
            }

            public TradingSessionStatus(
                    QuickFix.Fields.TradingSessionID aTradingSessionID,
                    QuickFix.Fields.TradSesStatus aTradSesStatus
                ) : this()
            {
                this.tradingSessionID = aTradingSessionID;
                this.tradSesStatus = aTradSesStatus;
            }

            public QuickFix.Fields.TradSesReqID tradSesReqID
            { 
                get 
                {
                    QuickFix.Fields.TradSesReqID val = new QuickFix.Fields.TradSesReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesReqID val) 
            { 
                this.tradSesReqID = val;
            }
            
            public QuickFix.Fields.TradSesReqID get(QuickFix.Fields.TradSesReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesReqID val) 
            { 
                return isSetTradSesReqID();
            }
            
            public bool isSetTradSesReqID() 
            { 
                return isSetField(Tags.TradSesReqID);
            }
            public QuickFix.Fields.TradingSessionID tradingSessionID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingSessionID val) 
            { 
                this.tradingSessionID = val;
            }
            
            public QuickFix.Fields.TradingSessionID get(QuickFix.Fields.TradingSessionID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingSessionID val) 
            { 
                return isSetTradingSessionID();
            }
            
            public bool isSetTradingSessionID() 
            { 
                return isSetField(Tags.TradingSessionID);
            }
            public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingSessionSubID val) 
            { 
                this.tradingSessionSubID = val;
            }
            
            public QuickFix.Fields.TradingSessionSubID get(QuickFix.Fields.TradingSessionSubID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingSessionSubID val) 
            { 
                return isSetTradingSessionSubID();
            }
            
            public bool isSetTradingSessionSubID() 
            { 
                return isSetField(Tags.TradingSessionSubID);
            }
            public QuickFix.Fields.TradSesMethod tradSesMethod
            { 
                get 
                {
                    QuickFix.Fields.TradSesMethod val = new QuickFix.Fields.TradSesMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesMethod val) 
            { 
                this.tradSesMethod = val;
            }
            
            public QuickFix.Fields.TradSesMethod get(QuickFix.Fields.TradSesMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesMethod val) 
            { 
                return isSetTradSesMethod();
            }
            
            public bool isSetTradSesMethod() 
            { 
                return isSetField(Tags.TradSesMethod);
            }
            public QuickFix.Fields.TradSesMode tradSesMode
            { 
                get 
                {
                    QuickFix.Fields.TradSesMode val = new QuickFix.Fields.TradSesMode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesMode val) 
            { 
                this.tradSesMode = val;
            }
            
            public QuickFix.Fields.TradSesMode get(QuickFix.Fields.TradSesMode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesMode val) 
            { 
                return isSetTradSesMode();
            }
            
            public bool isSetTradSesMode() 
            { 
                return isSetField(Tags.TradSesMode);
            }
            public QuickFix.Fields.UnsolicitedIndicator unsolicitedIndicator
            { 
                get 
                {
                    QuickFix.Fields.UnsolicitedIndicator val = new QuickFix.Fields.UnsolicitedIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                this.unsolicitedIndicator = val;
            }
            
            public QuickFix.Fields.UnsolicitedIndicator get(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                return isSetUnsolicitedIndicator();
            }
            
            public bool isSetUnsolicitedIndicator() 
            { 
                return isSetField(Tags.UnsolicitedIndicator);
            }
            public QuickFix.Fields.TradSesStatus tradSesStatus
            { 
                get 
                {
                    QuickFix.Fields.TradSesStatus val = new QuickFix.Fields.TradSesStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesStatus val) 
            { 
                this.tradSesStatus = val;
            }
            
            public QuickFix.Fields.TradSesStatus get(QuickFix.Fields.TradSesStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesStatus val) 
            { 
                return isSetTradSesStatus();
            }
            
            public bool isSetTradSesStatus() 
            { 
                return isSetField(Tags.TradSesStatus);
            }
            public QuickFix.Fields.TradSesStatusRejReason tradSesStatusRejReason
            { 
                get 
                {
                    QuickFix.Fields.TradSesStatusRejReason val = new QuickFix.Fields.TradSesStatusRejReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesStatusRejReason val) 
            { 
                this.tradSesStatusRejReason = val;
            }
            
            public QuickFix.Fields.TradSesStatusRejReason get(QuickFix.Fields.TradSesStatusRejReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesStatusRejReason val) 
            { 
                return isSetTradSesStatusRejReason();
            }
            
            public bool isSetTradSesStatusRejReason() 
            { 
                return isSetField(Tags.TradSesStatusRejReason);
            }
            public QuickFix.Fields.TradSesStartTime tradSesStartTime
            { 
                get 
                {
                    QuickFix.Fields.TradSesStartTime val = new QuickFix.Fields.TradSesStartTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesStartTime val) 
            { 
                this.tradSesStartTime = val;
            }
            
            public QuickFix.Fields.TradSesStartTime get(QuickFix.Fields.TradSesStartTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesStartTime val) 
            { 
                return isSetTradSesStartTime();
            }
            
            public bool isSetTradSesStartTime() 
            { 
                return isSetField(Tags.TradSesStartTime);
            }
            public QuickFix.Fields.TradSesOpenTime tradSesOpenTime
            { 
                get 
                {
                    QuickFix.Fields.TradSesOpenTime val = new QuickFix.Fields.TradSesOpenTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesOpenTime val) 
            { 
                this.tradSesOpenTime = val;
            }
            
            public QuickFix.Fields.TradSesOpenTime get(QuickFix.Fields.TradSesOpenTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesOpenTime val) 
            { 
                return isSetTradSesOpenTime();
            }
            
            public bool isSetTradSesOpenTime() 
            { 
                return isSetField(Tags.TradSesOpenTime);
            }
            public QuickFix.Fields.TradSesPreCloseTime tradSesPreCloseTime
            { 
                get 
                {
                    QuickFix.Fields.TradSesPreCloseTime val = new QuickFix.Fields.TradSesPreCloseTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesPreCloseTime val) 
            { 
                this.tradSesPreCloseTime = val;
            }
            
            public QuickFix.Fields.TradSesPreCloseTime get(QuickFix.Fields.TradSesPreCloseTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesPreCloseTime val) 
            { 
                return isSetTradSesPreCloseTime();
            }
            
            public bool isSetTradSesPreCloseTime() 
            { 
                return isSetField(Tags.TradSesPreCloseTime);
            }
            public QuickFix.Fields.TradSesCloseTime tradSesCloseTime
            { 
                get 
                {
                    QuickFix.Fields.TradSesCloseTime val = new QuickFix.Fields.TradSesCloseTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesCloseTime val) 
            { 
                this.tradSesCloseTime = val;
            }
            
            public QuickFix.Fields.TradSesCloseTime get(QuickFix.Fields.TradSesCloseTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesCloseTime val) 
            { 
                return isSetTradSesCloseTime();
            }
            
            public bool isSetTradSesCloseTime() 
            { 
                return isSetField(Tags.TradSesCloseTime);
            }
            public QuickFix.Fields.TradSesEndTime tradSesEndTime
            { 
                get 
                {
                    QuickFix.Fields.TradSesEndTime val = new QuickFix.Fields.TradSesEndTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesEndTime val) 
            { 
                this.tradSesEndTime = val;
            }
            
            public QuickFix.Fields.TradSesEndTime get(QuickFix.Fields.TradSesEndTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesEndTime val) 
            { 
                return isSetTradSesEndTime();
            }
            
            public bool isSetTradSesEndTime() 
            { 
                return isSetField(Tags.TradSesEndTime);
            }
            public QuickFix.Fields.TotalVolumeTraded totalVolumeTraded
            { 
                get 
                {
                    QuickFix.Fields.TotalVolumeTraded val = new QuickFix.Fields.TotalVolumeTraded();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                this.totalVolumeTraded = val;
            }
            
            public QuickFix.Fields.TotalVolumeTraded get(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                return isSetTotalVolumeTraded();
            }
            
            public bool isSetTotalVolumeTraded() 
            { 
                return isSetField(Tags.TotalVolumeTraded);
            }
            public QuickFix.Fields.Text text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Text val) 
            { 
                this.text = val;
            }
            
            public QuickFix.Fields.Text get(QuickFix.Fields.Text val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Text val) 
            { 
                return isSetText();
            }
            
            public bool isSetText() 
            { 
                return isSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen encodedTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedTextLen val) 
            { 
                this.encodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen get(QuickFix.Fields.EncodedTextLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return isSetEncodedTextLen();
            }
            
            public bool isSetEncodedTextLen() 
            { 
                return isSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText encodedText
            { 
                get 
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedText val) 
            { 
                this.encodedText = val;
            }
            
            public QuickFix.Fields.EncodedText get(QuickFix.Fields.EncodedText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedText val) 
            { 
                return isSetEncodedText();
            }
            
            public bool isSetEncodedText() 
            { 
                return isSetField(Tags.EncodedText);
            }
            public QuickFix.Fields.Symbol symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Symbol val) 
            { 
                this.symbol = val;
            }
            
            public QuickFix.Fields.Symbol get(QuickFix.Fields.Symbol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Symbol val) 
            { 
                return isSetSymbol();
            }
            
            public bool isSetSymbol() 
            { 
                return isSetField(Tags.Symbol);
            }
            public QuickFix.Fields.SymbolSfx symbolSfx
            { 
                get 
                {
                    QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SymbolSfx val) 
            { 
                this.symbolSfx = val;
            }
            
            public QuickFix.Fields.SymbolSfx get(QuickFix.Fields.SymbolSfx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SymbolSfx val) 
            { 
                return isSetSymbolSfx();
            }
            
            public bool isSetSymbolSfx() 
            { 
                return isSetField(Tags.SymbolSfx);
            }
            public QuickFix.Fields.SecurityID securityID
            { 
                get 
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityID val) 
            { 
                this.securityID = val;
            }
            
            public QuickFix.Fields.SecurityID get(QuickFix.Fields.SecurityID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityID val) 
            { 
                return isSetSecurityID();
            }
            
            public bool isSetSecurityID() 
            { 
                return isSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.SecurityIDSource securityIDSource
            { 
                get 
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityIDSource val) 
            { 
                this.securityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource get(QuickFix.Fields.SecurityIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return isSetSecurityIDSource();
            }
            
            public bool isSetSecurityIDSource() 
            { 
                return isSetField(Tags.SecurityIDSource);
            }
            public QuickFix.Fields.NoSecurityAltID noSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                this.noSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return isSetNoSecurityAltID();
            }
            
            public bool isSetNoSecurityAltID() 
            { 
                return isSetField(Tags.NoSecurityAltID);
            }
            public QuickFix.Fields.Product product
            { 
                get 
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Product val) 
            { 
                this.product = val;
            }
            
            public QuickFix.Fields.Product get(QuickFix.Fields.Product val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Product val) 
            { 
                return isSetProduct();
            }
            
            public bool isSetProduct() 
            { 
                return isSetField(Tags.Product);
            }
            public QuickFix.Fields.CFICode cFICode
            { 
                get 
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CFICode val) 
            { 
                this.cFICode = val;
            }
            
            public QuickFix.Fields.CFICode get(QuickFix.Fields.CFICode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CFICode val) 
            { 
                return isSetCFICode();
            }
            
            public bool isSetCFICode() 
            { 
                return isSetField(Tags.CFICode);
            }
            public QuickFix.Fields.SecurityType securityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityType val) 
            { 
                this.securityType = val;
            }
            
            public QuickFix.Fields.SecurityType get(QuickFix.Fields.SecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityType val) 
            { 
                return isSetSecurityType();
            }
            
            public bool isSetSecurityType() 
            { 
                return isSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.SecuritySubType securitySubType
            { 
                get 
                {
                    QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecuritySubType val) 
            { 
                this.securitySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType get(QuickFix.Fields.SecuritySubType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return isSetSecuritySubType();
            }
            
            public bool isSetSecuritySubType() 
            { 
                return isSetField(Tags.SecuritySubType);
            }
            public QuickFix.Fields.MaturityMonthYear maturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaturityMonthYear val) 
            { 
                this.maturityMonthYear = val;
            }
            
            public QuickFix.Fields.MaturityMonthYear get(QuickFix.Fields.MaturityMonthYear val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaturityMonthYear val) 
            { 
                return isSetMaturityMonthYear();
            }
            
            public bool isSetMaturityMonthYear() 
            { 
                return isSetField(Tags.MaturityMonthYear);
            }
            public QuickFix.Fields.MaturityDate maturityDate
            { 
                get 
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaturityDate val) 
            { 
                this.maturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate get(QuickFix.Fields.MaturityDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaturityDate val) 
            { 
                return isSetMaturityDate();
            }
            
            public bool isSetMaturityDate() 
            { 
                return isSetField(Tags.MaturityDate);
            }
            public QuickFix.Fields.CouponPaymentDate couponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                this.couponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return isSetCouponPaymentDate();
            }
            
            public bool isSetCouponPaymentDate() 
            { 
                return isSetField(Tags.CouponPaymentDate);
            }
            public QuickFix.Fields.IssueDate issueDate
            { 
                get 
                {
                    QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IssueDate val) 
            { 
                this.issueDate = val;
            }
            
            public QuickFix.Fields.IssueDate get(QuickFix.Fields.IssueDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IssueDate val) 
            { 
                return isSetIssueDate();
            }
            
            public bool isSetIssueDate() 
            { 
                return isSetField(Tags.IssueDate);
            }
            public QuickFix.Fields.RepoCollateralSecurityType repoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                this.repoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return isSetRepoCollateralSecurityType();
            }
            
            public bool isSetRepoCollateralSecurityType() 
            { 
                return isSetField(Tags.RepoCollateralSecurityType);
            }
            public QuickFix.Fields.RepurchaseTerm repurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                this.repurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return isSetRepurchaseTerm();
            }
            
            public bool isSetRepurchaseTerm() 
            { 
                return isSetField(Tags.RepurchaseTerm);
            }
            public QuickFix.Fields.RepurchaseRate repurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RepurchaseRate val) 
            { 
                this.repurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate get(QuickFix.Fields.RepurchaseRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return isSetRepurchaseRate();
            }
            
            public bool isSetRepurchaseRate() 
            { 
                return isSetField(Tags.RepurchaseRate);
            }
            public QuickFix.Fields.Factor factor
            { 
                get 
                {
                    QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Factor val) 
            { 
                this.factor = val;
            }
            
            public QuickFix.Fields.Factor get(QuickFix.Fields.Factor val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Factor val) 
            { 
                return isSetFactor();
            }
            
            public bool isSetFactor() 
            { 
                return isSetField(Tags.Factor);
            }
            public QuickFix.Fields.CreditRating creditRating
            { 
                get 
                {
                    QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CreditRating val) 
            { 
                this.creditRating = val;
            }
            
            public QuickFix.Fields.CreditRating get(QuickFix.Fields.CreditRating val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CreditRating val) 
            { 
                return isSetCreditRating();
            }
            
            public bool isSetCreditRating() 
            { 
                return isSetField(Tags.CreditRating);
            }
            public QuickFix.Fields.InstrRegistry instrRegistry
            { 
                get 
                {
                    QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.InstrRegistry val) 
            { 
                this.instrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry get(QuickFix.Fields.InstrRegistry val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return isSetInstrRegistry();
            }
            
            public bool isSetInstrRegistry() 
            { 
                return isSetField(Tags.InstrRegistry);
            }
            public QuickFix.Fields.CountryOfIssue countryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CountryOfIssue val) 
            { 
                this.countryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue get(QuickFix.Fields.CountryOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return isSetCountryOfIssue();
            }
            
            public bool isSetCountryOfIssue() 
            { 
                return isSetField(Tags.CountryOfIssue);
            }
            public QuickFix.Fields.StateOrProvinceOfIssue stateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                this.stateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return isSetStateOrProvinceOfIssue();
            }
            
            public bool isSetStateOrProvinceOfIssue() 
            { 
                return isSetField(Tags.StateOrProvinceOfIssue);
            }
            public QuickFix.Fields.LocaleOfIssue localeOfIssue
            { 
                get 
                {
                    QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                this.localeOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return isSetLocaleOfIssue();
            }
            
            public bool isSetLocaleOfIssue() 
            { 
                return isSetField(Tags.LocaleOfIssue);
            }
            public QuickFix.Fields.RedemptionDate redemptionDate
            { 
                get 
                {
                    QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RedemptionDate val) 
            { 
                this.redemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate get(QuickFix.Fields.RedemptionDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return isSetRedemptionDate();
            }
            
            public bool isSetRedemptionDate() 
            { 
                return isSetField(Tags.RedemptionDate);
            }
            public QuickFix.Fields.StrikePrice strikePrice
            { 
                get 
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikePrice val) 
            { 
                this.strikePrice = val;
            }
            
            public QuickFix.Fields.StrikePrice get(QuickFix.Fields.StrikePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikePrice val) 
            { 
                return isSetStrikePrice();
            }
            
            public bool isSetStrikePrice() 
            { 
                return isSetField(Tags.StrikePrice);
            }
            public QuickFix.Fields.StrikeCurrency strikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikeCurrency val) 
            { 
                this.strikeCurrency = val;
            }
            
            public QuickFix.Fields.StrikeCurrency get(QuickFix.Fields.StrikeCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikeCurrency val) 
            { 
                return isSetStrikeCurrency();
            }
            
            public bool isSetStrikeCurrency() 
            { 
                return isSetField(Tags.StrikeCurrency);
            }
            public QuickFix.Fields.OptAttribute optAttribute
            { 
                get 
                {
                    QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OptAttribute val) 
            { 
                this.optAttribute = val;
            }
            
            public QuickFix.Fields.OptAttribute get(QuickFix.Fields.OptAttribute val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OptAttribute val) 
            { 
                return isSetOptAttribute();
            }
            
            public bool isSetOptAttribute() 
            { 
                return isSetField(Tags.OptAttribute);
            }
            public QuickFix.Fields.ContractMultiplier contractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ContractMultiplier val) 
            { 
                this.contractMultiplier = val;
            }
            
            public QuickFix.Fields.ContractMultiplier get(QuickFix.Fields.ContractMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ContractMultiplier val) 
            { 
                return isSetContractMultiplier();
            }
            
            public bool isSetContractMultiplier() 
            { 
                return isSetField(Tags.ContractMultiplier);
            }
            public QuickFix.Fields.CouponRate couponRate
            { 
                get 
                {
                    QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CouponRate val) 
            { 
                this.couponRate = val;
            }
            
            public QuickFix.Fields.CouponRate get(QuickFix.Fields.CouponRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CouponRate val) 
            { 
                return isSetCouponRate();
            }
            
            public bool isSetCouponRate() 
            { 
                return isSetField(Tags.CouponRate);
            }
            public QuickFix.Fields.SecurityExchange securityExchange
            { 
                get 
                {
                    QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityExchange val) 
            { 
                this.securityExchange = val;
            }
            
            public QuickFix.Fields.SecurityExchange get(QuickFix.Fields.SecurityExchange val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityExchange val) 
            { 
                return isSetSecurityExchange();
            }
            
            public bool isSetSecurityExchange() 
            { 
                return isSetField(Tags.SecurityExchange);
            }
            public QuickFix.Fields.Issuer issuer
            { 
                get 
                {
                    QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Issuer val) 
            { 
                this.issuer = val;
            }
            
            public QuickFix.Fields.Issuer get(QuickFix.Fields.Issuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Issuer val) 
            { 
                return isSetIssuer();
            }
            
            public bool isSetIssuer() 
            { 
                return isSetField(Tags.Issuer);
            }
            public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                this.encodedIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedIssuerLen get(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                return isSetEncodedIssuerLen();
            }
            
            public bool isSetEncodedIssuerLen() 
            { 
                return isSetField(Tags.EncodedIssuerLen);
            }
            public QuickFix.Fields.EncodedIssuer encodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedIssuer val) 
            { 
                this.encodedIssuer = val;
            }
            
            public QuickFix.Fields.EncodedIssuer get(QuickFix.Fields.EncodedIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedIssuer val) 
            { 
                return isSetEncodedIssuer();
            }
            
            public bool isSetEncodedIssuer() 
            { 
                return isSetField(Tags.EncodedIssuer);
            }
            public QuickFix.Fields.SecurityDesc securityDesc
            { 
                get 
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityDesc val) 
            { 
                this.securityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc get(QuickFix.Fields.SecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return isSetSecurityDesc();
            }
            
            public bool isSetSecurityDesc() 
            { 
                return isSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                this.encodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDescLen get(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                return isSetEncodedSecurityDescLen();
            }
            
            public bool isSetEncodedSecurityDescLen() 
            { 
                return isSetField(Tags.EncodedSecurityDescLen);
            }
            public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                this.encodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDesc get(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                return isSetEncodedSecurityDesc();
            }
            
            public bool isSetEncodedSecurityDesc() 
            { 
                return isSetField(Tags.EncodedSecurityDesc);
            }
            public QuickFix.Fields.Pool pool
            { 
                get 
                {
                    QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Pool val) 
            { 
                this.pool = val;
            }
            
            public QuickFix.Fields.Pool get(QuickFix.Fields.Pool val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Pool val) 
            { 
                return isSetPool();
            }
            
            public bool isSetPool() 
            { 
                return isSetField(Tags.Pool);
            }
            public QuickFix.Fields.ContractSettlMonth contractSettlMonth
            { 
                get 
                {
                    QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ContractSettlMonth val) 
            { 
                this.contractSettlMonth = val;
            }
            
            public QuickFix.Fields.ContractSettlMonth get(QuickFix.Fields.ContractSettlMonth val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ContractSettlMonth val) 
            { 
                return isSetContractSettlMonth();
            }
            
            public bool isSetContractSettlMonth() 
            { 
                return isSetField(Tags.ContractSettlMonth);
            }
            public QuickFix.Fields.CPProgram cPProgram
            { 
                get 
                {
                    QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CPProgram val) 
            { 
                this.cPProgram = val;
            }
            
            public QuickFix.Fields.CPProgram get(QuickFix.Fields.CPProgram val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CPProgram val) 
            { 
                return isSetCPProgram();
            }
            
            public bool isSetCPProgram() 
            { 
                return isSetField(Tags.CPProgram);
            }
            public QuickFix.Fields.CPRegType cPRegType
            { 
                get 
                {
                    QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CPRegType val) 
            { 
                this.cPRegType = val;
            }
            
            public QuickFix.Fields.CPRegType get(QuickFix.Fields.CPRegType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CPRegType val) 
            { 
                return isSetCPRegType();
            }
            
            public bool isSetCPRegType() 
            { 
                return isSetField(Tags.CPRegType);
            }
            public QuickFix.Fields.NoEvents noEvents
            { 
                get 
                {
                    QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoEvents val) 
            { 
                this.noEvents = val;
            }
            
            public QuickFix.Fields.NoEvents get(QuickFix.Fields.NoEvents val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoEvents val) 
            { 
                return isSetNoEvents();
            }
            
            public bool isSetNoEvents() 
            { 
                return isSetField(Tags.NoEvents);
            }
            public QuickFix.Fields.DatedDate datedDate
            { 
                get 
                {
                    QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DatedDate val) 
            { 
                this.datedDate = val;
            }
            
            public QuickFix.Fields.DatedDate get(QuickFix.Fields.DatedDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DatedDate val) 
            { 
                return isSetDatedDate();
            }
            
            public bool isSetDatedDate() 
            { 
                return isSetField(Tags.DatedDate);
            }
            public QuickFix.Fields.InterestAccrualDate interestAccrualDate
            { 
                get 
                {
                    QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.InterestAccrualDate val) 
            { 
                this.interestAccrualDate = val;
            }
            
            public QuickFix.Fields.InterestAccrualDate get(QuickFix.Fields.InterestAccrualDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.InterestAccrualDate val) 
            { 
                return isSetInterestAccrualDate();
            }
            
            public bool isSetInterestAccrualDate() 
            { 
                return isSetField(Tags.InterestAccrualDate);
            }
            public QuickFix.Fields.SecurityStatus securityStatus
            { 
                get 
                {
                    QuickFix.Fields.SecurityStatus val = new QuickFix.Fields.SecurityStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityStatus val) 
            { 
                this.securityStatus = val;
            }
            
            public QuickFix.Fields.SecurityStatus get(QuickFix.Fields.SecurityStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityStatus val) 
            { 
                return isSetSecurityStatus();
            }
            
            public bool isSetSecurityStatus() 
            { 
                return isSetField(Tags.SecurityStatus);
            }
            public QuickFix.Fields.SettleOnOpenFlag settleOnOpenFlag
            { 
                get 
                {
                    QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                this.settleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.SettleOnOpenFlag get(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                return isSetSettleOnOpenFlag();
            }
            
            public bool isSetSettleOnOpenFlag() 
            { 
                return isSetField(Tags.SettleOnOpenFlag);
            }
            public QuickFix.Fields.InstrmtAssignmentMethod instrmtAssignmentMethod
            { 
                get 
                {
                    QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                this.instrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.InstrmtAssignmentMethod get(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                return isSetInstrmtAssignmentMethod();
            }
            
            public bool isSetInstrmtAssignmentMethod() 
            { 
                return isSetField(Tags.InstrmtAssignmentMethod);
            }
            public QuickFix.Fields.StrikeMultiplier strikeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikeMultiplier val) 
            { 
                this.strikeMultiplier = val;
            }
            
            public QuickFix.Fields.StrikeMultiplier get(QuickFix.Fields.StrikeMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikeMultiplier val) 
            { 
                return isSetStrikeMultiplier();
            }
            
            public bool isSetStrikeMultiplier() 
            { 
                return isSetField(Tags.StrikeMultiplier);
            }
            public QuickFix.Fields.StrikeValue strikeValue
            { 
                get 
                {
                    QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikeValue val) 
            { 
                this.strikeValue = val;
            }
            
            public QuickFix.Fields.StrikeValue get(QuickFix.Fields.StrikeValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikeValue val) 
            { 
                return isSetStrikeValue();
            }
            
            public bool isSetStrikeValue() 
            { 
                return isSetField(Tags.StrikeValue);
            }
            public QuickFix.Fields.MinPriceIncrement minPriceIncrement
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MinPriceIncrement val) 
            { 
                this.minPriceIncrement = val;
            }
            
            public QuickFix.Fields.MinPriceIncrement get(QuickFix.Fields.MinPriceIncrement val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MinPriceIncrement val) 
            { 
                return isSetMinPriceIncrement();
            }
            
            public bool isSetMinPriceIncrement() 
            { 
                return isSetField(Tags.MinPriceIncrement);
            }
            public QuickFix.Fields.PositionLimit positionLimit
            { 
                get 
                {
                    QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PositionLimit val) 
            { 
                this.positionLimit = val;
            }
            
            public QuickFix.Fields.PositionLimit get(QuickFix.Fields.PositionLimit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PositionLimit val) 
            { 
                return isSetPositionLimit();
            }
            
            public bool isSetPositionLimit() 
            { 
                return isSetField(Tags.PositionLimit);
            }
            public QuickFix.Fields.NTPositionLimit nTPositionLimit
            { 
                get 
                {
                    QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NTPositionLimit val) 
            { 
                this.nTPositionLimit = val;
            }
            
            public QuickFix.Fields.NTPositionLimit get(QuickFix.Fields.NTPositionLimit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NTPositionLimit val) 
            { 
                return isSetNTPositionLimit();
            }
            
            public bool isSetNTPositionLimit() 
            { 
                return isSetField(Tags.NTPositionLimit);
            }
            public QuickFix.Fields.NoInstrumentParties noInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoInstrumentParties val) 
            { 
                this.noInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoInstrumentParties get(QuickFix.Fields.NoInstrumentParties val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoInstrumentParties val) 
            { 
                return isSetNoInstrumentParties();
            }
            
            public bool isSetNoInstrumentParties() 
            { 
                return isSetField(Tags.NoInstrumentParties);
            }
            public QuickFix.Fields.UnitOfMeasure unitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnitOfMeasure val) 
            { 
                this.unitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnitOfMeasure get(QuickFix.Fields.UnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnitOfMeasure val) 
            { 
                return isSetUnitOfMeasure();
            }
            
            public bool isSetUnitOfMeasure() 
            { 
                return isSetField(Tags.UnitOfMeasure);
            }
            public QuickFix.Fields.TimeUnit timeUnit
            { 
                get 
                {
                    QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TimeUnit val) 
            { 
                this.timeUnit = val;
            }
            
            public QuickFix.Fields.TimeUnit get(QuickFix.Fields.TimeUnit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TimeUnit val) 
            { 
                return isSetTimeUnit();
            }
            
            public bool isSetTimeUnit() 
            { 
                return isSetField(Tags.TimeUnit);
            }
            public QuickFix.Fields.MaturityTime maturityTime
            { 
                get 
                {
                    QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaturityTime val) 
            { 
                this.maturityTime = val;
            }
            
            public QuickFix.Fields.MaturityTime get(QuickFix.Fields.MaturityTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaturityTime val) 
            { 
                return isSetMaturityTime();
            }
            
            public bool isSetMaturityTime() 
            { 
                return isSetField(Tags.MaturityTime);
            }
            public QuickFix.Fields.SecurityGroup securityGroup
            { 
                get 
                {
                    QuickFix.Fields.SecurityGroup val = new QuickFix.Fields.SecurityGroup();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityGroup val) 
            { 
                this.securityGroup = val;
            }
            
            public QuickFix.Fields.SecurityGroup get(QuickFix.Fields.SecurityGroup val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityGroup val) 
            { 
                return isSetSecurityGroup();
            }
            
            public bool isSetSecurityGroup() 
            { 
                return isSetField(Tags.SecurityGroup);
            }
            public QuickFix.Fields.MinPriceIncrementAmount minPriceIncrementAmount
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrementAmount val = new QuickFix.Fields.MinPriceIncrementAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                this.minPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.MinPriceIncrementAmount get(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                return isSetMinPriceIncrementAmount();
            }
            
            public bool isSetMinPriceIncrementAmount() 
            { 
                return isSetField(Tags.MinPriceIncrementAmount);
            }
            public QuickFix.Fields.UnitOfMeasureQty unitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasureQty val = new QuickFix.Fields.UnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                this.unitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnitOfMeasureQty get(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                return isSetUnitOfMeasureQty();
            }
            
            public bool isSetUnitOfMeasureQty() 
            { 
                return isSetField(Tags.UnitOfMeasureQty);
            }
            public QuickFix.Fields.SecurityXMLLen securityXMLLen
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLLen val = new QuickFix.Fields.SecurityXMLLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityXMLLen val) 
            { 
                this.securityXMLLen = val;
            }
            
            public QuickFix.Fields.SecurityXMLLen get(QuickFix.Fields.SecurityXMLLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityXMLLen val) 
            { 
                return isSetSecurityXMLLen();
            }
            
            public bool isSetSecurityXMLLen() 
            { 
                return isSetField(Tags.SecurityXMLLen);
            }
            public QuickFix.Fields.SecurityXML securityXML
            { 
                get 
                {
                    QuickFix.Fields.SecurityXML val = new QuickFix.Fields.SecurityXML();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityXML val) 
            { 
                this.securityXML = val;
            }
            
            public QuickFix.Fields.SecurityXML get(QuickFix.Fields.SecurityXML val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityXML val) 
            { 
                return isSetSecurityXML();
            }
            
            public bool isSetSecurityXML() 
            { 
                return isSetField(Tags.SecurityXML);
            }
            public QuickFix.Fields.SecurityXMLSchema securityXMLSchema
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLSchema val = new QuickFix.Fields.SecurityXMLSchema();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                this.securityXMLSchema = val;
            }
            
            public QuickFix.Fields.SecurityXMLSchema get(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                return isSetSecurityXMLSchema();
            }
            
            public bool isSetSecurityXMLSchema() 
            { 
                return isSetField(Tags.SecurityXMLSchema);
            }
            public QuickFix.Fields.ProductComplex productComplex
            { 
                get 
                {
                    QuickFix.Fields.ProductComplex val = new QuickFix.Fields.ProductComplex();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ProductComplex val) 
            { 
                this.productComplex = val;
            }
            
            public QuickFix.Fields.ProductComplex get(QuickFix.Fields.ProductComplex val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ProductComplex val) 
            { 
                return isSetProductComplex();
            }
            
            public bool isSetProductComplex() 
            { 
                return isSetField(Tags.ProductComplex);
            }
            public QuickFix.Fields.PriceUnitOfMeasure priceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasure val = new QuickFix.Fields.PriceUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                this.priceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasure get(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                return isSetPriceUnitOfMeasure();
            }
            
            public bool isSetPriceUnitOfMeasure() 
            { 
                return isSetField(Tags.PriceUnitOfMeasure);
            }
            public QuickFix.Fields.PriceUnitOfMeasureQty priceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasureQty val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                this.priceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasureQty get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                return isSetPriceUnitOfMeasureQty();
            }
            
            public bool isSetPriceUnitOfMeasureQty() 
            { 
                return isSetField(Tags.PriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.SettlMethod settlMethod
            { 
                get 
                {
                    QuickFix.Fields.SettlMethod val = new QuickFix.Fields.SettlMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlMethod val) 
            { 
                this.settlMethod = val;
            }
            
            public QuickFix.Fields.SettlMethod get(QuickFix.Fields.SettlMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlMethod val) 
            { 
                return isSetSettlMethod();
            }
            
            public bool isSetSettlMethod() 
            { 
                return isSetField(Tags.SettlMethod);
            }
            public QuickFix.Fields.ExerciseStyle exerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.ExerciseStyle val = new QuickFix.Fields.ExerciseStyle();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExerciseStyle val) 
            { 
                this.exerciseStyle = val;
            }
            
            public QuickFix.Fields.ExerciseStyle get(QuickFix.Fields.ExerciseStyle val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExerciseStyle val) 
            { 
                return isSetExerciseStyle();
            }
            
            public bool isSetExerciseStyle() 
            { 
                return isSetField(Tags.ExerciseStyle);
            }
            public QuickFix.Fields.OptPayAmount optPayAmount
            { 
                get 
                {
                    QuickFix.Fields.OptPayAmount val = new QuickFix.Fields.OptPayAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OptPayAmount val) 
            { 
                this.optPayAmount = val;
            }
            
            public QuickFix.Fields.OptPayAmount get(QuickFix.Fields.OptPayAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OptPayAmount val) 
            { 
                return isSetOptPayAmount();
            }
            
            public bool isSetOptPayAmount() 
            { 
                return isSetField(Tags.OptPayAmount);
            }
            public QuickFix.Fields.PriceQuoteMethod priceQuoteMethod
            { 
                get 
                {
                    QuickFix.Fields.PriceQuoteMethod val = new QuickFix.Fields.PriceQuoteMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                this.priceQuoteMethod = val;
            }
            
            public QuickFix.Fields.PriceQuoteMethod get(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                return isSetPriceQuoteMethod();
            }
            
            public bool isSetPriceQuoteMethod() 
            { 
                return isSetField(Tags.PriceQuoteMethod);
            }
            public QuickFix.Fields.ListMethod listMethod
            { 
                get 
                {
                    QuickFix.Fields.ListMethod val = new QuickFix.Fields.ListMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ListMethod val) 
            { 
                this.listMethod = val;
            }
            
            public QuickFix.Fields.ListMethod get(QuickFix.Fields.ListMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ListMethod val) 
            { 
                return isSetListMethod();
            }
            
            public bool isSetListMethod() 
            { 
                return isSetField(Tags.ListMethod);
            }
            public QuickFix.Fields.CapPrice capPrice
            { 
                get 
                {
                    QuickFix.Fields.CapPrice val = new QuickFix.Fields.CapPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CapPrice val) 
            { 
                this.capPrice = val;
            }
            
            public QuickFix.Fields.CapPrice get(QuickFix.Fields.CapPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CapPrice val) 
            { 
                return isSetCapPrice();
            }
            
            public bool isSetCapPrice() 
            { 
                return isSetField(Tags.CapPrice);
            }
            public QuickFix.Fields.FloorPrice floorPrice
            { 
                get 
                {
                    QuickFix.Fields.FloorPrice val = new QuickFix.Fields.FloorPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FloorPrice val) 
            { 
                this.floorPrice = val;
            }
            
            public QuickFix.Fields.FloorPrice get(QuickFix.Fields.FloorPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FloorPrice val) 
            { 
                return isSetFloorPrice();
            }
            
            public bool isSetFloorPrice() 
            { 
                return isSetField(Tags.FloorPrice);
            }
            public QuickFix.Fields.PutOrCall putOrCall
            { 
                get 
                {
                    QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PutOrCall val) 
            { 
                this.putOrCall = val;
            }
            
            public QuickFix.Fields.PutOrCall get(QuickFix.Fields.PutOrCall val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PutOrCall val) 
            { 
                return isSetPutOrCall();
            }
            
            public bool isSetPutOrCall() 
            { 
                return isSetField(Tags.PutOrCall);
            }
            public QuickFix.Fields.FlexibleIndicator flexibleIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexibleIndicator val = new QuickFix.Fields.FlexibleIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FlexibleIndicator val) 
            { 
                this.flexibleIndicator = val;
            }
            
            public QuickFix.Fields.FlexibleIndicator get(QuickFix.Fields.FlexibleIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FlexibleIndicator val) 
            { 
                return isSetFlexibleIndicator();
            }
            
            public bool isSetFlexibleIndicator() 
            { 
                return isSetField(Tags.FlexibleIndicator);
            }
            public QuickFix.Fields.FlexProductEligibilityIndicator flexProductEligibilityIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                this.flexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.FlexProductEligibilityIndicator get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                return isSetFlexProductEligibilityIndicator();
            }
            
            public bool isSetFlexProductEligibilityIndicator() 
            { 
                return isSetField(Tags.FlexProductEligibilityIndicator);
            }
            public QuickFix.Fields.FuturesValuationMethod futuresValuationMethod
            { 
                get 
                {
                    QuickFix.Fields.FuturesValuationMethod val = new QuickFix.Fields.FuturesValuationMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                this.futuresValuationMethod = val;
            }
            
            public QuickFix.Fields.FuturesValuationMethod get(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                return isSetFuturesValuationMethod();
            }
            
            public bool isSetFuturesValuationMethod() 
            { 
                return isSetField(Tags.FuturesValuationMethod);
            }
            public QuickFix.Fields.MarketID marketID
            { 
                get 
                {
                    QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketID val) 
            { 
                this.marketID = val;
            }
            
            public QuickFix.Fields.MarketID get(QuickFix.Fields.MarketID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketID val) 
            { 
                return isSetMarketID();
            }
            
            public bool isSetMarketID() 
            { 
                return isSetField(Tags.MarketID);
            }
            public QuickFix.Fields.MarketSegmentID marketSegmentID
            { 
                get 
                {
                    QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketSegmentID val) 
            { 
                this.marketSegmentID = val;
            }
            
            public QuickFix.Fields.MarketSegmentID get(QuickFix.Fields.MarketSegmentID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketSegmentID val) 
            { 
                return isSetMarketSegmentID();
            }
            
            public bool isSetMarketSegmentID() 
            { 
                return isSetField(Tags.MarketSegmentID);
            }
            public QuickFix.Fields.TradSesEvent tradSesEvent
            { 
                get 
                {
                    QuickFix.Fields.TradSesEvent val = new QuickFix.Fields.TradSesEvent();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradSesEvent val) 
            { 
                this.tradSesEvent = val;
            }
            
            public QuickFix.Fields.TradSesEvent get(QuickFix.Fields.TradSesEvent val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradSesEvent val) 
            { 
                return isSetTradSesEvent();
            }
            
            public bool isSetTradSesEvent() 
            { 
                return isSetField(Tags.TradSesEvent);
            }
            public QuickFix.Fields.ApplID applID
            { 
                get 
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplID val) 
            { 
                this.applID = val;
            }
            
            public QuickFix.Fields.ApplID get(QuickFix.Fields.ApplID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplID val) 
            { 
                return isSetApplID();
            }
            
            public bool isSetApplID() 
            { 
                return isSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum applSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.applSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum get(QuickFix.Fields.ApplSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return isSetApplSeqNum();
            }
            
            public bool isSetApplSeqNum() 
            { 
                return isSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum applLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.applLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return isSetApplLastSeqNum();
            }
            
            public bool isSetApplLastSeqNum() 
            { 
                return isSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag applResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.applResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag get(QuickFix.Fields.ApplResendFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return isSetApplResendFlag();
            }
            
            public bool isSetApplResendFlag() 
            { 
                return isSetField(Tags.ApplResendFlag);
            }
            public class NoSecurityAltID : Group
            {
                public NoSecurityAltID() 
                  :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
                            public QuickFix.Fields.SecurityAltID securityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityAltID val) 
                { 
                    this.securityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID get(QuickFix.Fields.SecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return isSetSecurityAltID();
                }
                
                public bool isSetSecurityAltID() 
                { 
                    return isSetField(Tags.SecurityAltID);
                }
                public QuickFix.Fields.SecurityAltIDSource securityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    this.securityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return isSetSecurityAltIDSource();
                }
                
                public bool isSetSecurityAltIDSource() 
                { 
                    return isSetField(Tags.SecurityAltIDSource);
                }
            
            }
            public class NoEvents : Group
            {
                public NoEvents() 
                  :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
                            public QuickFix.Fields.EventType eventType
                { 
                    get 
                    {
                        QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventType val) 
                { 
                    this.eventType = val;
                }
                
                public QuickFix.Fields.EventType get(QuickFix.Fields.EventType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventType val) 
                { 
                    return isSetEventType();
                }
                
                public bool isSetEventType() 
                { 
                    return isSetField(Tags.EventType);
                }
                public QuickFix.Fields.EventDate eventDate
                { 
                    get 
                    {
                        QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventDate val) 
                { 
                    this.eventDate = val;
                }
                
                public QuickFix.Fields.EventDate get(QuickFix.Fields.EventDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventDate val) 
                { 
                    return isSetEventDate();
                }
                
                public bool isSetEventDate() 
                { 
                    return isSetField(Tags.EventDate);
                }
                public QuickFix.Fields.EventPx eventPx
                { 
                    get 
                    {
                        QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventPx val) 
                { 
                    this.eventPx = val;
                }
                
                public QuickFix.Fields.EventPx get(QuickFix.Fields.EventPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventPx val) 
                { 
                    return isSetEventPx();
                }
                
                public bool isSetEventPx() 
                { 
                    return isSetField(Tags.EventPx);
                }
                public QuickFix.Fields.EventText eventText
                { 
                    get 
                    {
                        QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventText val) 
                { 
                    this.eventText = val;
                }
                
                public QuickFix.Fields.EventText get(QuickFix.Fields.EventText val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventText val) 
                { 
                    return isSetEventText();
                }
                
                public bool isSetEventText() 
                { 
                    return isSetField(Tags.EventText);
                }
                public QuickFix.Fields.EventTime eventTime
                { 
                    get 
                    {
                        QuickFix.Fields.EventTime val = new QuickFix.Fields.EventTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EventTime val) 
                { 
                    this.eventTime = val;
                }
                
                public QuickFix.Fields.EventTime get(QuickFix.Fields.EventTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EventTime val) 
                { 
                    return isSetEventTime();
                }
                
                public bool isSetEventTime() 
                { 
                    return isSetField(Tags.EventTime);
                }
            
            }
            public class NoInstrumentParties : Group
            {
                public NoInstrumentParties() 
                  :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
                            public QuickFix.Fields.InstrumentPartyID instrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyID val = new QuickFix.Fields.InstrumentPartyID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    this.instrumentPartyID = val;
                }
                
                public QuickFix.Fields.InstrumentPartyID get(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    return isSetInstrumentPartyID();
                }
                
                public bool isSetInstrumentPartyID() 
                { 
                    return isSetField(Tags.InstrumentPartyID);
                }
                public QuickFix.Fields.InstrumentPartyIDSource instrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    this.instrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.InstrumentPartyIDSource get(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    return isSetInstrumentPartyIDSource();
                }
                
                public bool isSetInstrumentPartyIDSource() 
                { 
                    return isSetField(Tags.InstrumentPartyIDSource);
                }
                public QuickFix.Fields.InstrumentPartyRole instrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    this.instrumentPartyRole = val;
                }
                
                public QuickFix.Fields.InstrumentPartyRole get(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    return isSetInstrumentPartyRole();
                }
                
                public bool isSetInstrumentPartyRole() 
                { 
                    return isSetField(Tags.InstrumentPartyRole);
                }
                public QuickFix.Fields.NoInstrumentPartySubIDs noInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    this.noInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoInstrumentPartySubIDs get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    return isSetNoInstrumentPartySubIDs();
                }
                
                public bool isSetNoInstrumentPartySubIDs() 
                { 
                    return isSetField(Tags.NoInstrumentPartySubIDs);
                }
                            public class NoInstrumentPartySubIDs : Group
                {
                    public NoInstrumentPartySubIDs() 
                      :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                                    public QuickFix.Fields.InstrumentPartySubID instrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubID val = new QuickFix.Fields.InstrumentPartySubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        this.instrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubID get(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        return isSetInstrumentPartySubID();
                    }
                    
                    public bool isSetInstrumentPartySubID() 
                    { 
                        return isSetField(Tags.InstrumentPartySubID);
                    }
                    public QuickFix.Fields.InstrumentPartySubIDType instrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        this.instrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubIDType get(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        return isSetInstrumentPartySubIDType();
                    }
                    
                    public bool isSetInstrumentPartySubIDType() 
                    { 
                        return isSetField(Tags.InstrumentPartySubIDType);
                    }
                
                }
            }
        }
    }
}